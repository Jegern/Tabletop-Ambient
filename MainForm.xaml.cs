﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Media.Animation;

namespace Spicy
{
    public partial class MainForm : Window
    {
        readonly ObservableCollection<Sound> collectionOfSounds;
        DoubleAnimation fadingAnimation;
        DoubleAnimation appearanceAnimation;
        int musicVolume = 100;
        int ambientVolume = 100;
        int sfxVolume = 100;

        public MainForm()
        {
            InitializeComponent();
            collectionOfSounds = new ObservableCollection<Sound>();
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            fadingAnimation = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromMilliseconds(500))
            };
            appearanceAnimation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromMilliseconds(500)),
            };
        }

        #region Sound Control

        private void MusicVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveOrReturnSound(MusicVolumeSlider, ref musicVolume);
        }

        private void RemoveOrReturnSound(Slider slider, ref int volume)
        {
            if (volume == 0)
            {
                volume = (int)slider.Value;
                slider.IsEnabled = true;
            }
            else
            {
                volume = 0;
                slider.IsEnabled = false;
            }
        }

        private void MusicVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            musicVolume = (int)(sender as Slider).Value;
        }

        private void AmbientVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveOrReturnSound(AmbientVolumeSlider, ref ambientVolume);
        }

        private void AmbientVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ambientVolume = (int)(sender as Slider).Value;
        }

        private void SfxVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveOrReturnSound(SfxVolumeSlider, ref sfxVolume);
        }

        private void SfxVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sfxVolume = (int)(sender as Slider).Value;
        }

        #endregion

        #region SFX Button Click

        private void SfxButton_Click(object sender, RoutedEventArgs e)
        {
            AddSfxToButton(sender);
        }

        private void AddSfxToButton(object sender)
        {
            Button button = sender as Button;
            string buttonNumber = Regex.Match(button.Name, @"[0-9]{1,2}").ToString();
            AddIconToSfxButton(button, "sfxButtonIcon" + buttonNumber);
            AddTextToSfxTextBlock("sfxTextBlock" + buttonNumber, "SFX звук");
        }

        private void AddIconToSfxButton(Button button, string buttonIconName)
        {
            Ellipse ellipse = button.Template.FindName(buttonIconName, button) as Ellipse;
            ellipse.Fill = new ImageBrush(new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "//images/Sound icon.png")));
        }

        private void AddTextToSfxTextBlock(string textBlockName, string text)
        {
            TextBlock textBlock = sfxGrid.FindName(textBlockName) as TextBlock;
            textBlock.Text = text;
        }

        #endregion

        private void ListOfReadyMadeTemplates_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo("bin/templates/");
            foreach (var fileName in directory.GetFiles("*.bin"))
                ListOfTemplates.Items.Add(fileName.Name.Replace(".bin", ""));
            ListOfTemplates.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void CreateTemplateButton_Click(object sender, RoutedEventArgs e)
        {
            TemplateCreationForm templateCreationForm = new TemplateCreationForm();
            templateCreationForm.Owner = this;
            templateCreationForm.Show();
        }

        private void DeleteTemplateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfTemplates.SelectedIndex != -1)
            {
                File.Delete("bin/templates/" + ListOfTemplates.SelectedItem.ToString() + ".bin");
                ListOfTemplates.Items.RemoveAt(ListOfTemplates.SelectedIndex);
            }
        }

        #region List of templates selection

        private void ListOfTemplates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListOfTemplates.SelectedIndex != -1)
            {
                ChangeTemplateNameTextBlock();
                LoadTemplateSoundsInCollection();
                AddSoundsInListAndSort();
            }
        }

        private void ChangeTemplateNameTextBlock()
        {
            TemplateName.Text = ListOfTemplates.SelectedItem.ToString();
        }

        private void LoadTemplateSoundsInCollection()
        {
            collectionOfSounds.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open("bin/templates/" + TemplateName.Text + ".bin", FileMode.Open)))
                while (reader.PeekChar() != -1)
                {
                    string[] soundNameAndSettings = reader.ReadString().Split(new[] { ".wav" }, StringSplitOptions.None);
                    string[] soundSettings = soundNameAndSettings[1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string soundName = soundNameAndSettings[0];
                    int soundVolume = Convert.ToInt32(soundSettings[0]);
                    int soundRepetitionRate = Convert.ToInt32(soundSettings[1]);
                    collectionOfSounds.Add(new Sound(soundName, soundVolume, soundRepetitionRate));
                }
        }

        private void AddSoundsInListAndSort()
        {
            ListOfSounds.ItemsSource = collectionOfSounds;
            ListOfSounds.DisplayMemberPath = "Name";
            ListOfSounds.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        #endregion

        #region Button Animation

        private void sfxButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AnimationForButtonIconAndTextBlock(sender, appearanceAnimation);
        }

        private void AnimationForButtonIconAndTextBlock(object sender, DoubleAnimation animation)
        {
            Button button = sender as Button;
            string buttonNumber = Regex.Match(button.Name, @"[0-9]{1,2}").ToString();
            Ellipse ellipse = button.Template.FindName("sfxButtonIcon" + buttonNumber, button) as Ellipse;
            TextBlock textBlock = sfxGrid.FindName("sfxTextBlock" + buttonNumber) as TextBlock;
            ellipse.BeginAnimation(OpacityProperty, animation);
            textBlock.BeginAnimation(OpacityProperty, animation);
        }

        private void sfxButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AnimationForButtonIconAndTextBlock(sender, fadingAnimation);
        }

        #endregion

        #region List of sounds selection

        private void ListOfSounds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListOfTemplates.SelectedIndex != -1)
            {
                SoundVolumeSlider.Value = (ListOfSounds.SelectedItem as Sound).Volume;
                SoundRepetitionRateTextbox.Text = (ListOfSounds.SelectedItem as Sound).RepetitionRate.ToString();
            }
        }

        private void SoundVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ListOfSounds.SelectedIndex != -1)
                (ListOfSounds.SelectedItem as Sound).Volume = (int)SoundVolumeSlider.Value;
        }

        private void SoundRepetitionRateTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ListOfSounds.SelectedIndex != -1 && SoundRepetitionRateTextbox.Text.Length != 0)
                (ListOfSounds.SelectedItem as Sound).RepetitionRate = Convert.ToInt32(SoundRepetitionRateTextbox.Text);
        }

        #endregion
    }
}

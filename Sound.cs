﻿namespace Spicy
{
    public partial class TemplateCreationForm
    {
        class Sound
        {
            public Sound(string Name, int Volume, int RepetitionRate)
            {
                this.Name = Name;
                this.Volume = Volume;
                this.RepetitionRate = RepetitionRate;
            }

            public string Name { get; }

            public int Volume { get; set; }

            public int RepetitionRate { get; set; }
        }
    }

    public partial class MainForm
    {
        class Sound
        {
            public Sound(string Name, int Volume, int RepetitionRate)
            {
                this.Name = Name;
                this.Volume = Volume;
                this.RepetitionRate = RepetitionRate;
            }

            public string Name { get; }

            public int Volume { get; set; }

            public int RepetitionRate { get; set; }
        }
    }
}
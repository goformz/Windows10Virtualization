using System;
using System.Collections.ObjectModel;

namespace TestXamlVirt
{
    public class TextItem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public string ID { get; set; }
    }

    public class ExampleItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }

        public ObservableCollection<TextItem> TextItems { get; set; }
    }

    public class ExampleItemViewModel
    {
        public static int Pages = 100000;
        public static int Controls = 10;

        private ObservableCollection<ExampleItem> exampleItems = new ObservableCollection<ExampleItem>();
        public ObservableCollection<ExampleItem> ExampleItems { get { return this.exampleItems; } }
        
        public ExampleItemViewModel()
        {
            Random random = new Random();

            for (int i = 0; i < Pages; i++)
            {
                var page = new ExampleItem()
                {
                    Title = "Title: " + i.ToString(),
                    Subtitle = "Sub: " + i.ToString(),
                    Description = "Desc: " + i.ToString(),
                    TextItems = new ObservableCollection<TextItem>()
                };

                for (int j = 0; j < Controls; ++j)
                {
                    page.TextItems.Add(
                            new TextItem()
                            {
                                X = random.Next(800),
                                Y = random.Next(1000),
                                W = 50,
                                H = 20,
                                ID = $"i:{i} j:{j}"
                            }
                        );
                }

                exampleItems.Add(page);
            }
            
        }
    }
}

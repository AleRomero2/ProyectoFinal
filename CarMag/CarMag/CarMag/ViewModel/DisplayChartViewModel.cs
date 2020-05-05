using System;
using System.Collections.Generic;
using System.Text;
using Microcharts;
using SkiaSharp;
namespace CarMag.ViewModel
{
    class DisplayChartViewModel
    {
        public Chart RadielGaugeChartSample => new RadialGaugeChart()
        {
            Entries = new[]
    {
                new Entry(100)
                {
                    Color = SKColor.Parse("#ff80ff"),
                    TextColor = SKColor.Parse("#ff80ff"),
                    Label = "Gasolina",
                    ValueLabel = "100%"
                },
                new Entry(75)
                {
                    Color = SKColor.Parse("#A8F4B4"),
                    TextColor = SKColor.Parse("#A8F4B4"),
                    Label = "Gastos",
                    ValueLabel = "75%",
                },
                new Entry(25)
                {
                    Color = SKColor.Parse("#B7A8F4"),
                    TextColor = SKColor.Parse("#B7A8F4"),
                    Label = "Servicios",
                    ValueLabel = "25%"
                },
            },
            LineSize = 25,
            //AnimationDuration = new TimeSpan(6000),
            LabelTextSize = 45,
        };
    }
}

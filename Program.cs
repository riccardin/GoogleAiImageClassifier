using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Cloud.Vision.V1;

namespace ImageClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the image file.");
                return;
            }

            string imagePath = args[0];
            var categories = new List<string> { "People", "Technology", "post-it", "Faces", "Feelings" };

            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile(imagePath);
            var response = client.DetectLabels(image);

            var categoryProbabilities = new Dictionary<string, float>();

            foreach (var category in categories)
            {
                categoryProbabilities[category] = 0.0f;
            }

            foreach (var annotation in response)
            {
                if (categories.Contains(annotation.Description))
                {
                    categoryProbabilities[annotation.Description] = annotation.Score;
                }
            }

            foreach (var category in categories)
            {
                Console.WriteLine($"{category}: {categoryProbabilities[category]}");
            }
        }
    }
}

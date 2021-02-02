using ML_NET_ML.Model;
using System;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How do you like our product? ");
            string emotion = Console.ReadLine();

            ModelInput input = new ModelInput()
            {
                Col0 = $"{emotion}",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(input);

            // If prediction is 1 sentiment is "Positive" otherwise it is "Negative"
            string sentiment = predictionResult.Prediction == "1" ? "Positive feeling" : "Negative feeling";

            Console.WriteLine();

            Console.WriteLine($"Answer: {input.Col0}, \nSentiment: {sentiment}");
        }
    }
}

namespace SeriesTracker;

public static class Helper
{
    public static int PromptInt(this string question, string? description = null, int minValue = 0,
        int maxValue = int.MaxValue, int? defaultValue = null)
    {
        Console.Write(
            $"{question}{(string.IsNullOrEmpty(description) ? "" : $" ({description})")}{(defaultValue == null ? "" : $" [default {defaultValue.Value.ToString()}]")}: ");
        int response;

        string? InputOrDefault()
        {
            var input = Console.ReadLine();
            return string.IsNullOrEmpty(input) && defaultValue != null ? defaultValue.ToString() : input;
        }

        while (!int.TryParse(InputOrDefault(), out response) ||
               response < minValue ||
               response > maxValue)
        {
            var range = "";
            if (minValue != 0 || maxValue != int.MaxValue)
            {
                range = $" [{minValue}-{maxValue}]";
            }

            Console.Write($"Enter a valid number:{range} ");
        }

        return response;
    }

    public static string? PromptString(this string question, string? description = null, string? defaultValue = null)
    {
        string? InputOrDefault()
        {
            var input = Console.ReadLine();
            return string.IsNullOrEmpty(input) && defaultValue != null ? defaultValue : input;
        }

        string? response;
        do
        {
            Console.Write(
                $"{question}{(string.IsNullOrEmpty(description) ? "" : $" ({description})")}{(defaultValue == null ? "" : $" [default {defaultValue}]")}: ");
            response = InputOrDefault();
        } while (string.IsNullOrWhiteSpace(response) && response != defaultValue);

        return response;
    }
}

internal class Program
{
    static void Main()
    {
        Dictionary<string, Action<List<string>, List<string>>> mapper = new()
        {
            { "Add", AddLesson },
            { "Insert", InsertLessonAtIndex },
            { "Remove", RemoveLessonByTitle },
            { "Swap", SwapLessonsByTitle },
            { "Exercise", AddExercise }
        };

        List<string> lessonsList = Console.ReadLine()
            .Split(", ")
            .ToList();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "course start")
            {
                PrintLessons(lessonsList);
                break;
            }

            string[] tokens = line.Split(":").ToArray();

            string command = tokens[0];

            mapper[command](lessonsList, tokens.Skip(1).ToList());
        }
    }

    static void AddLesson(List<string> arr, List<string> tokens)
    {
        string lessonTitle = tokens[0];
        if (!arr.Contains(lessonTitle))
        {
            arr.Add(lessonTitle);
        }
    }

    static void InsertLessonAtIndex(List<string> arr, List<string> tokens)
    {
        string lessonTitle = tokens[0];
        int index = int.Parse(tokens[1]);
        if (!arr.Contains(lessonTitle))
        {
            arr.Insert(index, lessonTitle);
        }
    }
    static void RemoveLessonByTitle(List<string> arr, List<string> tokens)
    {
        string lessonTitle = tokens[0];
        if (arr.Contains(lessonTitle))
        {
            arr.Remove(lessonTitle);
        }
        if (arr.Contains(GetLessonExercise(lessonTitle)))
        {
            arr.Remove(lessonTitle);
        }
    }
    static void AddExercise(List<string> arr, List<string> tokens)
    {
        string lessonTitle = tokens[0];
        string exerciseTitle = GetLessonExercise(lessonTitle);

        if (arr.Contains(lessonTitle) && !arr.Contains(exerciseTitle))
        {
            int lessonIndex = arr.IndexOf(lessonTitle);
            arr.Insert(lessonIndex + 1, exerciseTitle);
            return;
        }

        AddLesson(arr, new List<string> { lessonTitle });
        AddLesson(arr, new List<string> { exerciseTitle });
    }

    static void SwapLessonsByTitle(List<string> arr, List<string> tokens)
    {
        string firstLesson = tokens[0];
        string firstExercise = GetLessonExercise(firstLesson);
        int firstIndex = arr.IndexOf(firstLesson);

        string secondLesson = tokens[1];
        string secondExercise = GetLessonExercise(secondLesson);
        int secondIndex = arr.IndexOf(secondLesson);

        if (!arr.Contains(firstLesson) || !arr.Contains(secondLesson))
        {
            return;
        }

        if (arr.Contains(firstLesson) && arr.Contains(secondLesson))
        {
            arr[firstIndex] = secondLesson;
            arr[secondIndex] = firstLesson;

        }

        if (!arr.Contains(firstExercise) && arr.Contains(secondExercise))
        {
            arr.RemoveAt(secondIndex + 1);
            AddExercise(arr, new List<string> { secondLesson });
        }

        if (arr.Contains(firstExercise) && !arr.Contains(secondExercise))
        {
            arr.RemoveAt(firstIndex + 1);
            AddExercise(arr, new List<string> { firstLesson });
        }
    }

    static void PrintLessons(List<string> arr)
    {
        int idx = 1;
        foreach (string item in arr)
        {
            Console.WriteLine($"{idx}.{item}");
            idx++;
        }
    }

    static string GetLessonExercise(string lessonTitle)
    {
        return $"{lessonTitle}-Exercise";
    }

}

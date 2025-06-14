using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Type your code here
        int n = int.Parse(Console.ReadLine());
        string[] skills = new string[n];
        for(int i=0;i<n;i++){
            skills[i] = Console.ReadLine();
        }
        Dictionary<string, List<string>> groups = new Dictionary<>();
        foreach(string skill in skills){
            string key = new string(skill.ToLower().Replace(" ","").OrderBy(c=>c).ToArray());
            if(!groups.ContainsKey(key)){
                groups[key] = new List<string>();
            }
            groups[key].Add(skill);
        }
        foreach(var group in groups.Values){
            Console.WriteLine("Group: "+string.Join(", ", group));
        }

    }
}
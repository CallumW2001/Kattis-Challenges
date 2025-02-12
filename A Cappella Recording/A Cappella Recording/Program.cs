using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int numOfNotes = inputs[0];
int largestDifference = inputs[1];

List<int> pitches = new List<int>();

for(int i = 0; i < numOfNotes; i++)
{
    pitches.Add(int.Parse(Console.ReadLine()));
}

pitches.Sort();

int recordings = 1;
int currentNote = pitches[0];

for (int i = 1; i < pitches.Count; i++)
{
    if (pitches[i] > currentNote + largestDifference && pitches[i] != currentNote)
    {
        recordings++;
        currentNote = pitches[i];
    }
    
}

Console.WriteLine(recordings);

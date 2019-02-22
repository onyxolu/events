﻿using Microsoft.ML.Data;

namespace MLNetDemo010.Shared
{
    public class AgeRange
    {
        [LoadColumn(0)]
        public string Name;

        [LoadColumn(1)]
        public float Age;

        [LoadColumn(2)]
        public string Gender;

        [LoadColumn(3), ColumnName("Label")]
        public string Label;
    }
}
﻿namespace BlazorEcom.Shared
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        public List<Ingredient> Ingredients = new();
        public string Instruction { get; set; } = string.Empty;
        public float Price { get; set; }
    }
}
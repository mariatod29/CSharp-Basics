using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Дефинирайте клас, който съдържа информация за характеристики на екрана (големина и цветове)
public class Display
{
    float size;
    int colorsCount;

    public Display(float size, int colorsCount)
    {
        this.size = size;
        this.colorsCount = colorsCount;
    }
    public float Size
    {
        get { return size; }
        set
        {
            if (value < 0) throw new ArgumentException("Invalid size input!");
            this.size = value;
        }
    }
    public int ColorsCount
    {
        get { return colorsCount; }
        set {
            if (value < 0) throw new ArgumentException("Invalid count for colors!");
            this.colorsCount = value; }
    }
    public override string ToString()
    {
        return String.Format("Size: {0}, Colors: {1}", this.size, this.colorsCount);
    }
}
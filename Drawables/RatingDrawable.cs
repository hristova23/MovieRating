namespace MovieRating.Drawables;

internal class RatingDrawable : IDrawable
{
    public readonly Color DefaultStrokeColor = Colors.Black;
    public readonly Color DefaultColor = Colors.Gray;
    public readonly int DefaultItemCount = 5;
    public readonly float StrokeWidth = 1f;

    public readonly float ItemSize = 24f;
    public readonly float ItemSpacing = 6f;
    public readonly string StarShapePath = "M885.344,319.071l-258-3.8l-102.7-264.399c-19.8-48.801-88.899-48.801-108.6,0l-102.7,264.399l-258,3.8\n\t\tc-53.4,3.101-75.1,70.2-33.7,103.9l209.2,181.4l-71.3,247.7c-14,50.899,41.1,92.899,86.5,65.899l224.3-122.7l224.3,122.601\n\t\tc45.4,27,100.5-15,86.5-65.9l-71.3-247.7l209.2-181.399C960.443,389.172,938.744,322.071,885.344,319.071z";

    public int Value { get; set; }

    public Color Color { get; set; }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        //draw each star
        for (int itemIndex = 0; itemIndex < DefaultItemCount; itemIndex++)
        {
            DrawRatingItem(canvas, dirtyRect, itemIndex);
        }
    }

    private void DrawRatingItem(ICanvas canvas, RectF dirtyRect, int itemIndex)
    {
        canvas.SaveState();

        //set the position
        canvas.Translate(itemIndex * ItemSize + itemIndex * ItemSpacing + StrokeWidth, StrokeWidth);

        //build the shape
        var pathBuilder = new PathBuilder();
        var shapePath = pathBuilder.BuildPath(StarShapePath);
        var scaledShapePath = shapePath.AsScaledPath((ItemSize - StrokeWidth) / (shapePath.Bounds.Width < shapePath.Bounds.Height ? shapePath.Bounds.Width : shapePath.Bounds.Height));

        var clippedPath = new PathF();
        clippedPath.AppendRectangle(0, 0, Convert.ToSingle(scaledShapePath.Bounds.Width * (Value - itemIndex)), scaledShapePath.Bounds.Height);

        if (itemIndex < Value)
            DrawStar(canvas, scaledShapePath, Color);
        else
            DrawStar(canvas, scaledShapePath, DefaultColor);

        canvas.RestoreState();
    }

    private void DrawStar(ICanvas canvas, PathF shapePath, Color fillColor)
    {
        //set item colors and strokes
        canvas.StrokeColor = DefaultStrokeColor;
        canvas.StrokeSize = StrokeWidth;
        canvas.FillColor = fillColor;

        //draw 
        canvas.DrawPath(shapePath);
        canvas.FillPath(shapePath);
    }
}


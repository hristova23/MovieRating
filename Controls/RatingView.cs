namespace MovieRating.Controls;

public class RatingView : GraphicsView
{
    private RatingDrawable _drawableCanvas;

    private int defaultHeightRequest = 26;
    private int defaultWidthRequest = 148;

    #region Properties

    public static readonly BindableProperty ValueProperty = BindableProperty.Create(
        nameof(Value),
        typeof(int),
        typeof(RatingView),
        2,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateValue();
        });

    public int Value
    {
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    private void UpdateValue()
    {
        _drawableCanvas.Value = Value;
        HeightRequest = defaultHeightRequest;
        WidthRequest = defaultWidthRequest;
        Invalidate();
    }

    public static readonly BindableProperty ColorProperty = BindableProperty.Create(
        nameof(Color),
        typeof(Color),
        typeof(RatingView),
        Color.FromArgb("#FFFF00"),
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateColor();
        });

    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    private void UpdateColor()
    {
        _drawableCanvas.Color = Color;
        HeightRequest = defaultHeightRequest;
        WidthRequest = defaultWidthRequest;
        Invalidate();
    }

    public static readonly BindableProperty IsReadOnlyProperty = BindableProperty.Create(
        nameof(IsReadOnly),
        typeof(bool),
        typeof(RatingView),
        true,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateIsReadOnly();
        });

    public bool IsReadOnly
    {
        get => (bool)GetValue(IsReadOnlyProperty);
        set => SetValue(IsReadOnlyProperty, value);
    }

    private void UpdateIsReadOnly()
    {
        //TODO: Implement...
    }

    #endregion

    protected override void OnParentSet()
    {
        base.OnParentSet();

        if (Parent is null)
            return;

        UpdateColor();
        UpdateValue();
    }

    public RatingView()
    {
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += OnTapped;
        GestureRecognizers.Add(tapGesture);

        _drawableCanvas = new RatingDrawable();

        Drawable = _drawableCanvas;
    }

    private async void OnTapped(object sender, EventArgs e)
    {
        //TODO: handle event...
        Application.Current.MainPage.DisplayAlert("Inception","some desctiption about the movie...","close");
    }
}
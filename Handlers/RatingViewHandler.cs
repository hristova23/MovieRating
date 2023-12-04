//using Microsoft.Maui.Handlers;

//namespace MovieRating.Handlers;

//public partial class RatingViewHandler : GraphicsViewHandler
//{
//    static IPropertyMapper<RatingView, RatingViewHandler> PropertyMapper = new PropertyMapper<RatingView, RatingViewHandler>(GraphicsViewHandler.Mapper)
//    {
//        [nameof(RatingView.Value)] = MapRatingValue,
//        [nameof(RatingView.Color)] = MapRatingColor

//        //TODO: IsReadOnly?
//        //[nameof(RatingView.IsReadOnly)] = MapRatingIsReadOnly
//    };

//    public RatingViewHandler() : base(PropertyMapper)
//    {
//    }

//    static void MapRatingValue(RatingViewHandler handler, RatingView view)
//    {
//        if (view.Drawable is RatingDrawable drawable)
//        {
//            drawable.Value = view.Value;
//        }
//        view.Invalidate();

//        //if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
//        //    rating.UpdateValue();
//        //_drawableCanvas.Value = Value;
//        //HeightRequest = defaultHeightRequest;
//        //WidthRequest = defaultWidthRequest;
//        //Invalidate();
//    }
//    static void MapRatingColor(RatingViewHandler handler, RatingView view)
//    {
//        if (view.Drawable is RatingDrawable drawable)
//        {
//            drawable.Color = view.Color;
//        }
//        view.Invalidate();

//        //if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
//        //    rating.UpdateColor();
//        //_drawableCanvas.Color = Color;
//        //HeightRequest = defaultHeightRequest;
//        //WidthRequest = defaultWidthRequest;
//        //Invalidate();
//    }
//}
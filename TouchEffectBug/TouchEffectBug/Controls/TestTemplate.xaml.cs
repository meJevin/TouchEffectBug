using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TouchEffectBug.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestTemplate : ContentView
    {
        public static readonly BindableProperty HasTouchEffectsProperty =
            BindableProperty.Create(nameof(HasTouchEffects), typeof(bool), typeof(TestTemplate), false,
                propertyChanged: OnHasTouchEffectsChanged);

        public bool HasTouchEffects
        {
            get { return (bool)GetValue(HasTouchEffectsProperty); }
            set { SetValue(HasTouchEffectsProperty, value); }
        }

        static void OnHasTouchEffectsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            TestTemplate i = (TestTemplate)bindable;

            if ((bool)newValue == false)
            {
                i.RemoveEffects();
            }
            else
            {
                i.AddEffects();
            }
        }

        public TestTemplate()
        {
            InitializeComponent();
        }

        public void RemoveEffects()
        {
            //MainContainer.Effects.Remove(MainContainer.Effects[0]);
            //MainContainer.ClearValue(TouchEffect.PressedScaleProperty);
            //MainContainer.ClearValue(TouchEffect.AnimationEasingProperty);
            //MainContainer.ClearValue(TouchEffect.AnimationDurationProperty);
            //MainContainer.RemoveBinding(TouchEffect.LongPressCommandProperty);
            //MainContainer.ClearValue(TouchEffect.LongPressCommandProperty);
            //MainContainer.RemoveBinding(TouchEffect.LongPressCommandParameterProperty);
            //MainContainer.ClearValue(TouchEffect.LongPressCommandParameterProperty);
        }

        public void AddEffects()
        {
            //Binding longPressBinding = new Binding();
            //longPressBinding.Source = new RelativeBindingSource(RelativeBindingSourceMode.FindAncestorBindingContext,
            //    typeof(MainPage), 1);
            //longPressBinding.Path = nameof(MainPage.LongPressCommand);

            //Binding longPressCommandBinding = new Binding();
            //longPressCommandBinding.Source = this.BindingContext;

            //MainContainer.SetValue(TouchEffect.PressedScaleProperty, 0.95);
            //MainContainer.SetValue(TouchEffect.AnimationEasingProperty, Easing.CubicOut);
            //MainContainer.SetValue(TouchEffect.AnimationDurationProperty, 650);
            //MainContainer.SetBinding(TouchEffect.LongPressCommandProperty, longPressBinding);
            //MainContainer.SetBinding(TouchEffect.LongPressCommandParameterProperty, longPressCommandBinding);
        }
    }
}
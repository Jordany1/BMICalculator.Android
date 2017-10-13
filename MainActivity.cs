using Android.App;
using Android.Widget;
using Android.OS;

namespace BMICalculator.Android
{
    [Activity(Label = "BMICalculator.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button calculateButton;
        TextView resultTextView;
        EditText heightEditText, weightEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };

            calculateButton = FindViewById<Button>(BMICalculator.Android.Resources.Id.calculateButton);
            resultTextView = FindViewById<Button>(BMICalculator.Android.Resources.Id.calculateButton);
            heightEditText = FindViewById<Button>(BMICalculator.Android.Resources.Id.calculateButton);
            weightEditText = FindViewById<Button>(BMICalculator.Android.Resources.Id.calculateButton);

            calculateButton.Click += calculateButton_Click;
        }

        void CalculateButton_Click(object sender, System.EventArgs e)
        {
            float height = float.Parse(heightEditText.Text);
            float weight = float.Parse(weightEditText.Text);

            float bmi = (weight / (height * height));

            resultTextView.Text = bmi.ToString ();
        }
    }
}

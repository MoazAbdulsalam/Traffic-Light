namespace Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ctrlTrafficLights1.Start();
            ctrlTrafficLights2.Start();
            ctrlTrafficLights3.Start();
        }

        private void ctrlTrafficLights1_GreenLightOn(object sender, Traffic_Light.ctrlTrafficLights.TraficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} : {e.LightDuration}");
        }

        private void ctrlTrafficLights1_OrangeLightOn(object sender, Traffic_Light.ctrlTrafficLights.TraficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} : {e.LightDuration}");

        }

        private void ctrlTrafficLights1_RedLightOn(object sender, Traffic_Light.ctrlTrafficLights.TraficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} : {e.LightDuration}");

        }
    }
}

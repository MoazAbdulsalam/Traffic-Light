using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Traffic_Light.Properties;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Traffic_Light
{
    public partial class ctrlTrafficLights : UserControl
    {
        public class TraficLightEventArgs : EventArgs
        {
            public Lights CurrentLight { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(Lights CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }
        public event EventHandler<TraficLightEventArgs> RedLightOn;
        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        void RaiseRedLightOn()
        {
            RedLightOn?.Invoke(this, new TraficLightEventArgs(Lights.Red, RedTime));
        }
        void RaiseGreenLightOn()
        {
            GreenLightOn?.Invoke(this, new TraficLightEventArgs(Lights.Green, GreenTime));
        }
        void RaiseOrangeLightOn()
        {
            OrangeLightOn?.Invoke(this, new TraficLightEventArgs(Lights.Orange, OrangeTime));
        }

        public enum Lights { Red, Green, Orange }
        Lights _CurrentLight;
        Lights _LightAfterOrange;
        byte _GreenTime = 5;
        byte _OrangeTime = 3;
        byte _RedTime = 9;
        byte _CurrentCountDownValue;

        public Lights CurrentLight
        {
            get { return _CurrentLight; }
            set
            {
                _CurrentLight = value;
                switch (value)
                {
                    case Lights.Red:
                        pbLight.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;
                    case Lights.Green:
                        pbLight.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;
                    case Lights.Orange:
                        pbLight.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        break;
                    default:
                        break;
                }
            }
        }
        public byte GreenTime { get { return _GreenTime; } set { _GreenTime = value; } }
        public byte RedTime { get { return _RedTime; } set { _RedTime = value; } }
        public byte OrangeTime { get { return _OrangeTime; } set { _OrangeTime = value; } }

        public byte GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case Lights.Red:
                    return RedTime;
                case Lights.Green:
                    return GreenTime;
                case Lights.Orange:
                    return OrangeTime;

                default: return RedTime;
            }
        }

        void _ChangeColor()
        {
            switch (_CurrentLight)
            {
                case Lights.Red:

                    CurrentLight = Lights.Orange;
                    _LightAfterOrange = Lights.Green;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;
                case Lights.Orange:
                    if (_LightAfterOrange == Lights.Green)
                    {
                        CurrentLight = Lights.Green;
                        _LightAfterOrange = Lights.Red;
                        _CurrentCountDownValue = GreenTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();

                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = Lights.Red;
                        _LightAfterOrange = Lights.Green;
                        _CurrentCountDownValue = RedTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();

                        RaiseRedLightOn();
                    }
                    break;
                case Lights.Green:
                    CurrentLight = Lights.Orange;
                    _LightAfterOrange = Lights.Red;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();

                    RaiseOrangeLightOn();
                    break;

            }
        }
        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            timer1.Start();
        }
        public void stop()
        {
            timer1.Stop();
        }

        public ctrlTrafficLights()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCountDown.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue != 0)
            {
                _CurrentCountDownValue--;
            }
            else
            {
                _ChangeColor();
            }
        }


    }
}

using System.Collections.Generic;

namespace PracticeSession.Core
{
    /// <summary>
    /// A single factor affecting the behavior of a DSP Effect
    /// </summary>
    /// <remarks>
    /// A DSP Effect can have one or more Factors
    /// </remarks>
    public class DSPEffectFactor
    {
        private List<string> _discreteValueText;

        public DSPEffectFactor(float defaultValue, float minimum, float maximum, float increment, string description)
        {
            this.Default = defaultValue;
            this.Value = defaultValue;
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Increment = increment;
            this.Description = description;
            _discreteValueText = new List<string>();
        }

        public string Description { get; set; }
        public float Default { get; private set; }
        public float Minimum { get; private set; }
        public float Maximum { get; private set; }
        public float Increment { get; private set; }
        public float Value { get; set; }

        public IList<string> DiscreteValueText { get { return _discreteValueText; } }
    }
}

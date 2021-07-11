using System;
using System.Collections.Generic;

namespace PracticeSession.Core
{
    /// <summary>
    /// Base class for all DSP effects
    /// Based on the Slider class written by Mark Heath, SkypeFX
    /// </summary>
    public abstract class DSPEffect
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DSPEffect()
        {
            m_factors = new List<DSPEffectFactor>();
            Enabled = true;
            SampleRate = 44100;
        }

        /// <summary>
        /// Builder method - Adds a DSP effect factor to the DSP effect
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="increment"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public DSPEffectFactor AddFactor(float defaultValue, float minimum, float maximum, float increment, string description)
        {
            DSPEffectFactor factor = new DSPEffectFactor(defaultValue, minimum, maximum, increment, description);
            m_factors.Add(factor);
            return factor;
        }

        public abstract string Name { get; }
        public IList<DSPEffectFactor> Factors { get { return m_factors; } }
        public float SampleRate { get; set; }
        public bool Enabled { get; set; }

        // helper base methods
        // these are primarily to enable derived classes to use a similar
        // syntax to JS effects
        protected float Factor1 { get { return m_factors[0].Value; } }
        protected float Factor2 { get { return m_factors[1].Value; } }
        protected float Factor3 { get { return m_factors[2].Value; } }
        protected float Factor4 { get { return m_factors[3].Value; } }
        protected float Factor5 { get { return m_factors[4].Value; } }
        protected float Factor6 { get { return m_factors[5].Value; } }
        protected float Factor7 { get { return m_factors[6].Value; } }
        protected float Factor8 { get { return m_factors[7].Value; } }
        protected float Min(float a, float b) { return Math.Min(a, b); }
        protected float Max(float a, float b) { return Math.Max(a, b); }
        protected float Abs(float a) { return Math.Abs(a); }
        protected float Exp(float a) { return (float)Math.Exp(a); }
        protected float Sqrt(float a) { return (float)Math.Sqrt(a); }
        protected float Sin(float a) { return (float)Math.Sin(a); }
        protected float Tan(float a) { return (float)Math.Tan(a); }
        protected float Cos(float a) { return (float)Math.Cos(a); }
        protected float Pow(float a, float b) { return (float)Math.Pow(a, b); }
        protected float Sign(float a) { return Math.Sign(a); }
        protected float Log(float a) { return (float)Math.Log(a); }

        protected const float Db2log = 0.11512925464970228420089957273422f; // ln(10) / 20 
        protected const float PI = 3.1415926535f;
        protected const float HalfPi = 1.57079632675f; // pi / 2;
        protected const float HalfPiScaled = 2.218812643387445f; // halfpi * 1.41254f;

        /// <summary>
        /// Performs a convolution operations between buffer 1 and buffer 2
        /// </summary>
        /// <param name="buffer1"></param>
        /// <param name="offset1"></param>
        /// <param name="buffer2"></param>
        /// <param name="offset2"></param>
        /// <param name="count"></param>
        protected void Convolve(float[] buffer1, int offset1, float[] buffer2, int offset2, int count)
        {
            for (int sampleIndex = 0; sampleIndex < count * 2; sampleIndex += 2)
            {
                float r = buffer1[offset1 + sampleIndex];
                float im = buffer1[offset1 + sampleIndex + 1];
                float cr = buffer2[offset2 + sampleIndex];
                float ci = buffer2[offset2 + sampleIndex + 1];
                buffer1[offset1 + sampleIndex] = r * cr - im * ci;
                buffer1[offset1 + sampleIndex + 1] = r * ci + im * cr;
            }
        }

        /// <summary>
        /// Should be called on effect load, sample rate changes, and start of playback
        /// </summary>
        public virtual void Init()
        {
        }

        /// <summary>
        /// will be called when a factor value has been changed
        /// </summary>
        public abstract void OnFactorChanges();

        /// <summary>
        /// called before each block is processed
        /// </summary>
        /// <param name="samplesblock">number of samples in this block</param>
        public virtual void Block(int samplesBlock)
        {
        }

        /// <summary>
        /// Processed a single sample - should be called for each sample
        /// </summary>        
        public abstract void Sample(ref float spl0, ref float spl1);

        public override string ToString()
        {
            return Name;
        }

        protected List<DSPEffectFactor> m_factors;

        public const int DefaultSampleRate = 44100;
    }
}

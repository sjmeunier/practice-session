using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeSession.SoundTouchSharp
{
    /// <summary>
    /// .NET C# Wrapper to the SoundTouch Native C++ Audio library
    /// </summary>
    /// <see cref="http://www.surina.net/soundtouch/index.html"/>
    public class SoundTouchSharpWrapper : IDisposable
    {
        #region SoundTouch .NET wrapper API

        /// <summary>
        /// Create a new instance of SoundTouch processor.
        /// </summary>
        public void CreateInstance()
        {
            if (_handle != IntPtr.Zero)
            {
                throw new ApplicationException("SoundSharp Instance was already initialized but not destroyed. Use DestroyInstance().");
            }

            _handle = NativeMethods.soundtouch_createInstance();
            var soundTouchVersion = GetVersionString();
            var soundTouchVersionId = GetVersionId();
            Console.Out.WriteLine("SoundTouch version: {0}, {1}", soundTouchVersion, SoundTouchVersionId);
        }

        /// <summary>
        /// Destroys a SoundTouch processor instance.
        /// </summary>
        private void DestroyInstance()
        {
            if (_handle != IntPtr.Zero)
            {
                NativeMethods.soundtouch_destroyInstance(_handle);
                _handle = IntPtr.Zero;
            }
        }

        /// <summary>
        /// Get SoundTouch library version string
        /// </summary>
        /// <returns></returns>
        public string GetVersionString()
        {
            StringBuilder versionString = new StringBuilder(100);
            NativeMethods.soundtouch_getVersionString2(versionString, 100);

            return versionString.ToString();
        }

        /// <summary>
        /// Get SoundTouch library version Id
        /// </summary>
        /// <returns></returns>
        public int GetVersionId()
        {
            SoundTouchVersionId = NativeMethods.soundtouch_getVersionId();

            return SoundTouchVersionId;
        }

        /// <summary>
        /// Sets new rate control value. Normal rate = 1.0, smaller values
        /// represent slower rate, larger faster rates.
        /// </summary>
        /// <param name="newRate"></param>
        public void SetRate(float newRate)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setRate(_handle, newRate);
        }

        /// <summary>
        /// Sets new tempo control value. Normal tempo = 1.0, smaller values
        /// represent slower tempo, larger faster tempo.
        /// </summary>
        /// <param name="newTempo"></param>
        public void SetTempo(float newTempo)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setTempo(_handle, newTempo);
        }

        /// <summary>
        /// Sets new rate control value as a difference in percents compared
        /// to the original rate (-50 .. +100 %);
        /// </summary>
        /// <param name="newRate"></param>
        public void SetRateChange(float newRate)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setRateChange(_handle, newRate);
        }

        /// <summary>
        /// Sets new tempo control value as a difference in percents compared
        /// to the original tempo (-50 .. +100 %)
        /// </summary>
        /// <param name="newRate"></param>
        public void SetTempoChange(float newTempo)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setTempoChange(_handle, newTempo);
        }

        /// <summary>
        /// Sets new pitch control value. Original pitch = 1.0, smaller values
        /// represent lower pitches, larger values higher pitch.
        /// </summary>
        /// <param name="newPitch"></param>
        public void SetPitch(float newPitch)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setPitch(_handle, newPitch);
        }

        /// <summary>
        /// Sets pitch change in octaves compared to the original pitch (-1.00 .. +1.00)
        /// </summary>
        /// <param name="newPitch"></param>
        public void SetPitchOctaves(float newPitch)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setPitchOctaves(_handle, newPitch);
        }

        /// <summary>
        /// Sets pitch change in semi-tones compared to the original pitch (12 .. +12)
        /// </summary>
        /// <param name="newPitch"></param>
        public void SetPitchSemiTones(float newPitch)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setPitchSemiTones(_handle, newPitch);
        }


        /// <summary>
        /// Sets the number of channels, 1 = mono, 2 = stereo
        /// </summary>
        /// <param name="numChannels"></param>
        public void SetChannels(int numChannels)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setChannels(_handle, (uint)numChannels);
        }

        /// <summary>
        /// Sets sample rate.
        /// </summary>
        /// <param name="srate"></param>
        public void SetSampleRate(int srate)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setSampleRate(_handle, (uint)srate);
        }

        /// <summary>
        /// Flushes the last samples from the processing pipeline to the output.
        /// Clears also the internal processing buffers.
        //
        /// Note: This function is meant for extracting the last samples of a sound
        /// stream. This function may introduce additional blank samples in the end
        /// of the sound stream, and thus it's not recommended to call this function
        /// in the middle of a sound stream.
        /// </summary>
        public void Flush()
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_flush(_handle);
        }

        /// <summary>
        /// Adds 'numSamples' pcs of samples from the 'samples' memory position into
        /// the input of the object. Notice that sample rate _has_to_ be set before
        /// calling this function, otherwise throws a runtime_error exception.
        /// </summary>
        /// <param name="pSamples"></param>
        /// <param name="numSamples"></param>
        public void PutSamples(float[] pSamples, uint numSamples)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_putSamples(_handle, pSamples, numSamples);
        }

        /// <summary>
        /// Clears all the samples in the object's output and internal processing buffers.
        /// </summary>
        public void Clear()
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_clear(_handle);
        }

        /// <summary>
        /// Changes a setting controlling the processing system behaviour. See the
        /// 'SETTING_...' defines for available setting ID's.
        /// 
        /// \return 'TRUE' if the setting was succesfully changed
        /// </summary>
        public void SetSetting(SoundTouchSettings settingId, int value)
        {
            VerifyInstanceInitialized();

            NativeMethods.soundtouch_setSetting(_handle, (int)settingId, value);
        }

        /// <summary>
        /// Reads a setting controlling the processing system behaviour. 
        /// See the 'SETTING_...' defines for available setting ID's.
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns>Returns the setting value.</returns>
        public int GetSetting(SoundTouchSettings settingId)
        {
            VerifyInstanceInitialized();

            return NativeMethods.soundtouch_getSetting(_handle, (int)settingId);
        }

        /// <summary>
        /// Returns number of samples currently unprocessed.
        /// </summary>
        /// <returns></returns>
        public int GetNumUnprocessedSamples()
        {
            VerifyInstanceInitialized();

            return NativeMethods.soundtouch_numUnprocessedSamples(_handle);
        }

        /// <summary>
        /// Adjusts book-keeping so that given number of samples are removed from beginning of the 
        /// sample buffer without copying them anywhere. 
        ///
        /// Used to reduce the number of samples in the buffer when accessing the sample buffer directly
        /// with 'ptrBegin' function.
        /// </summary>
        /// <param name="pOutBuffer"></param>
        /// <param name="maxSamples"></param>
        /// <returns></returns>
        public uint ReceiveSamples(float[] pOutBuffer, uint maxSamples)
        {
            VerifyInstanceInitialized();

            return NativeMethods.soundtouch_receiveSamples(_handle, pOutBuffer, maxSamples);
        }

        /// <summary>
        /// Returns number of samples currently available.
        /// </summary>
        /// <returns></returns>
        public int GetNumSamples()
        {
            VerifyInstanceInitialized();

            return NativeMethods.soundtouch_numSamples(_handle);
        }

        /// <summary>
        /// Returns nonzero if there aren't any samples available for outputting.
        /// </summary>
        /// <returns></returns>
        public int IsEmpty()
        {
            VerifyInstanceInitialized();

            return NativeMethods.soundtouch_isEmpty(_handle);
        }

        


        #endregion

        #region SoundSharp Native API - DLL Imports

        public class NativeMethods
        {
            public const string SoundTouchDLLName = "SoundTouch.dll";

            #region C DLL Header
            /*

    /// Create a new instance of SoundTouch processor.
    SOUNDTOUCHDLL_API HANDLE __stdcall soundtouch_createInstance();

    /// Destroys a SoundTouch processor instance.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_destroyInstance(HANDLE h);

    /// Get SoundTouch library version string
    SOUNDTOUCHDLL_API const char *__stdcall soundtouch_getVersionString();

    /// Get SoundTouch library version Id
    SOUNDTOUCHDLL_API unsigned int __stdcall soundtouch_getVersionId();

    /// Sets new rate control value. Normal rate = 1.0, smaller values
    /// represent slower rate, larger faster rates.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setRate(HANDLE h, float newRate);

    /// Sets new tempo control value. Normal tempo = 1.0, smaller values
    /// represent slower tempo, larger faster tempo.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setTempo(HANDLE h, float newTempo);

    /// Sets new rate control value as a difference in percents compared
    /// to the original rate (-50 .. +100 %);
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setRateChange(HANDLE h, float newRate);

    /// Sets new tempo control value as a difference in percents compared
    /// to the original tempo (-50 .. +100 %);
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setTempoChange(HANDLE h, float newTempo);

    /// Sets new pitch control value. Original pitch = 1.0, smaller values
    /// represent lower pitches, larger values higher pitch.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setPitch(HANDLE h, float newPitch);

    /// Sets pitch change in octaves compared to the original pitch  
    /// (-1.00 .. +1.00);
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setPitchOctaves(HANDLE h, float newPitch);

    /// Sets pitch change in semi-tones compared to the original pitch
    /// (-12 .. +12);
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setPitchSemiTones(HANDLE h, float newPitch);


    /// Sets the number of channels, 1 = mono, 2 = stereo
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setChannels(HANDLE h, unsigned int numChannels);

    /// Sets sample rate.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_setSampleRate(HANDLE h, unsigned int srate);

    /// Flushes the last samples from the processing pipeline to the output.
    /// Clears also the internal processing buffers.
    //
    /// Note: This function is meant for extracting the last samples of a sound
    /// stream. This function may introduce additional blank samples in the end
    /// of the sound stream, and thus it's not recommended to call this function
    /// in the middle of a sound stream.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_flush(HANDLE h);

    /// Adds 'numSamples' pcs of samples from the 'samples' memory position into
    /// the input of the object. Notice that sample rate _has_to_ be set before
    /// calling this function, otherwise throws a runtime_error exception.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_putSamples(HANDLE h, 
            const float *samples,       ///< Pointer to sample buffer.
            unsigned int numSamples     ///< Number of samples in buffer. Notice
                                        ///< that in case of stereo-sound a single sample
                                        ///< contains data for both channels.
            );

    /// Clears all the samples in the object's output and internal processing
    /// buffers.
    SOUNDTOUCHDLL_API void __stdcall soundtouch_clear(HANDLE h);

    /// Changes a setting controlling the processing system behaviour. See the
    /// 'SETTING_...' defines for available setting ID's.
    /// 
    /// \return 'TRUE' if the setting was succesfully changed
    SOUNDTOUCHDLL_API BOOL __stdcall soundtouch_setSetting(HANDLE h, 
                    int settingId,   ///< Setting ID number. see SETTING_... defines.
                    int value        ///< New setting value.
                    );

    /// Reads a setting controlling the processing system behaviour. See the
    /// 'SETTING_...' defines for available setting ID's.
    ///
    /// \return the setting value.
    SOUNDTOUCHDLL_API int __stdcall soundtouch_getSetting(HANDLE h, 
                              int settingId    ///< Setting ID number, see SETTING_... defines.
                    );


    /// Returns number of samples currently unprocessed.
    SOUNDTOUCHDLL_API unsigned int __stdcall soundtouch_numUnprocessedSamples(HANDLE h);

    /// Adjusts book-keeping so that given number of samples are removed from beginning of the 
    /// sample buffer without copying them anywhere. 
    ///
    /// Used to reduce the number of samples in the buffer when accessing the sample buffer directly
    /// with 'ptrBegin' function.
    SOUNDTOUCHDLL_API unsigned int __stdcall soundtouch_receiveSamples(HANDLE h, 
                float *outBuffer,           ///< Buffer where to copy output samples.
                unsigned int maxSamples     ///< How many samples to receive at max.
                );

    /// Returns number of samples currently available.
    SOUNDTOUCHDLL_API unsigned int __stdcall soundtouch_numSamples(HANDLE h);

    /// Returns nonzero if there aren't any samples available for outputting.
    SOUNDTOUCHDLL_API int __stdcall soundtouch_isEmpty(HANDLE h);

    */
            #endregion

#pragma warning disable IDE1006 // Naming Styles

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr soundtouch_createInstance();

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_destroyInstance(IntPtr h);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern int soundtouch_getVersionId();

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0")]
            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            internal static extern void soundtouch_getVersionString2(StringBuilder versionString, int bufferSize);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setRate(IntPtr h, float newRate);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setTempo(IntPtr h, float newTempo);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setRateChange(IntPtr h, float newRate);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setTempoChange(IntPtr h, float newTempo);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setPitch(IntPtr h, float newPitch);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setPitchOctaves(IntPtr h, float newPitch);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setPitchSemiTones(IntPtr h, float newPitch);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setChannels(IntPtr h, uint numChannels);

            /// Sets sample rate.
            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_setSampleRate(IntPtr h, uint srate);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_flush(IntPtr h);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_putSamples(IntPtr h, [MarshalAs(UnmanagedType.LPArray)] float[] samples, uint numSamples);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void soundtouch_clear(IntPtr h);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern bool soundtouch_setSetting(IntPtr h, int settingId, int value);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern int soundtouch_getSetting(IntPtr h, int settingId);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern int soundtouch_numUnprocessedSamples(IntPtr h);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern uint soundtouch_receiveSamples(IntPtr h, [MarshalAs(UnmanagedType.LPArray)] float[] outBuffer, uint maxSamples);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern int soundtouch_numSamples(IntPtr h);

            [DllImport(SoundTouchDLLName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern int soundtouch_isEmpty(IntPtr h);

#pragma warning restore IDE1006 // Naming Styles

        }

        #endregion

        #region IDisposable Members

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // Dispose of resources held by this instance.
                DestroyInstance();

                disposed = true;

                // Suppress finalization of this disposed instance.
                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        ~SoundTouchSharpWrapper()
        {
            Dispose(false);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Helper function for validating the SoundTouch as initialized
        /// </summary>
        private void VerifyInstanceInitialized()
        {
            if (_handle == IntPtr.Zero)
            {
                throw new ApplicationException("SoundTouch as not initialized. Use CreateInstance()");
            }
        }

        #endregion

        #region Members

        private IntPtr _handle = IntPtr.Zero;

        public string SoundTouchVersionString { get; private set; }
        public int SoundTouchVersionId { get; private set; }

        #endregion
    }

    #region ByteAndFloatsConverter - Conversion Utility Structure (Byte[] <-> Float[])

    /// <summary>
    /// Helper Structure - Allows "C-Style forced pointer" conversion of Bytes array to Floats array and visa versa (C# does not allow this)
    /// The main benefit is performance - no need to iterate and convert each element in the array
    /// Taken from: http://stackoverflow.com/questions/619041/what-is-the-fastest-way-to-convert-a-float-to-a-byte
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct ByteAndFloatsConverter
    {
        [FieldOffset(0)]
        public Byte[] Bytes;

        [FieldOffset(0)]
        public float[] Floats;
    }

    #endregion
}

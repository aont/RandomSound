using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RandomSound
{
    class winmm
    {


        /// <summary>
        /// コールバック関数のデリゲート
        /// </summary>
        /// <param name="hmo">MIDI 出力デバイスのハンドル</param>
        /// <param name="hwnd">MIDI 出力の状態を表すメッセージ</param>
        /// <param name="dwInstance">関数で提供されたユーザー定義のインスタンスデータ</param>
        /// <param name="dwParam1">メッセージの追加情報1</param>
        /// <param name="dwParam2">メッセージの追加情報2</param>
        public delegate void MidiOutProc(
            IntPtr hmo,
            uint hwnd,
            int dwInstance,
            int dwParam1,
            int dwParam2
            );

        [DllImport("Winmm.dll")]
        public static extern uint midiOutGetNumDevs();

        /// <summary>MIDI出力デバイスを開く
        /// </summary>
        /// <param name="lphmo">MIDI出力デバイスのハンドルへのポインタ</param>
        /// <param name="uDeviceID">オープンするMIDI出力デバイスの識別子</param>
        /// <param name="dwCallback">MIDI出力に関連したメッセージを受け取るコールバック関数、ウィンドウハンドル、スレッドハンドルのいずれか</param>
        /// <param name="dwCallbackInstance">コールバック関数に渡す追加データ</param>
        /// <param name="dwFlags">コールバックのタイプ(CALLBACKクラス定数)</param>
        /// <returns>
        /// MIDIERR.NODEVICE,
        /// MMSYSERR.NOERROR,
        /// MMSYSERR.ALLOCATED,
        /// MMSYSERR.BADDEVICEID,
        /// MMSYSERR.INVALPARAM,
        /// MMSYSERR.NOMEM
        /// </returns>
        [DllImport("Winmm.dll")]
        public static extern uint midiOutOpen(
            out IntPtr lphmo,
                int uDeviceID,
                MidiOutProc dwCallback,
                int dwCallbackInstance,
                CALLBACK dwFlags
            );


        /// <summary>開いたデバイスにMIDIメッセージを送信</summary>
        /// <param name="hmo">MIDI 出力デバイスのハンドル</param>
        /// <param name="dwMsg">MIDI メッセージ</param>
        /// <returns></returns>
        [DllImport("Winmm.dll")]
        public static extern uint midiOutShortMsg(IntPtr hmo, int dwMsg);

        public static uint midiOutShortMsg(IntPtr hmo, byte status, byte channel, byte data1, byte data2)
        {
            return midiOutShortMsg(hmo, (status << 4) | channel | (data1 << 8) | (data2 << 16));
        }
        public static uint midiOutShortMsg(IntPtr hmo, byte status, byte channel, GMProgram data1, byte data2)
        {
            return midiOutShortMsg(hmo, (status << 4) | channel | ((byte)data1 << 8) | (data2 << 16));
        }


        /// <summary>
        /// 再生を停止
        /// </summary>
        /// <param name="hmo">MIDI出力デバイスのハンドル</param>
        /// <returns>
        /// MMSYSERR.NOERROR,
        /// MMSYSERR.INVALHANDLE
        /// </returns>
        [DllImport("Winmm.dll")]
        public static extern uint midiOutReset(IntPtr hmo);

        /// <summary>
        /// デバイスを閉じる
        /// </summary>
        /// <param name="hmo">MIDI出力デバイスのハンドル</param>
        /// <returns>
        /// MMSYSERR.NOERROR,
        /// MIDIERR.STILLPLAYING,
        /// MMSYSERR.INVALHANDLE,
        /// MMSYSERR.NOMEM
        /// </returns>
        [DllImport("Winmm.dll")]
        public static extern uint midiOutClose(IntPtr hmo);


    }

    /// <summary>Callbackの種類</summary>
    public enum CALLBACK
    {
        /// <summary>イベントハンドル</summary>
        EVENT = 0x50000,
        /// <summary>コールバック関数のポインタ</summary>
        FUNCTION = 0x30000,
        /// <summary>使用しない</summary>
        NULL = 0x0,
        /// <summary>スレッドハンドル</summary>
        THREAD = 0x20000,
        /// <summary>ウィンドウハンドル</summary>
        WINDOW = 0x10000,
    }

    public static class MIDI
    {
        /// <summary>優先されるデバイス</summary>
        public const int MAPPAR = -1;
    }


    public static class MIDIERR
    {
        private const uint BASE = 64;
        /// <summary>メッセージにステータスバイトがない</summary>
        public const uint NODEVICE = BASE + 4;
        /// <summary>MIDI ポートが見つからない</summary>
        public const uint BADOPENMODE = BASE + 6;
        /// <summary>デバイスが別のスレッドで使われている </summary>
        public const uint NOTREADY = BASE + 3;
        /// <summary>デバイスが別のスレッドで使われている </summary>
        public const uint STILLPLAYING = BASE + 1;

    }


    public static class MMSYSERR
    {
        private const uint BASE = 0;
        /// <summary>指定のリソースはすでに割り当てられている </summary>
        public const uint ALLOCATED = BASE + 4;
        /// <summary>指定のデバイス識別子が不正である</summary>
        public const uint BADDEVICEID = BASE + 2;
        /// <summary>指定のポインタ、構造体は無効である</summary>
        public const uint INVALPARAM = BASE + 11;
        /// <summary>必要なメモリを割り当てる事ができなかった</summary>
        public const uint NOMEM = BASE + 7;
        /// <summary>指定のデバイスハンドルが無効である</summary>
        public const uint INVALHANDLE = BASE + 5;
    }
    public enum GMProgram : byte
    {
        AcousticGrandPiano, BrightAcousticPiano, ElectricGrandPiano, HonkyTonkPiano, ElectricPiano1, ElectricPiano2, Harpsichord, Clavinet, Celesta, Glockenspiel, MusicBox, Vibraphone, Marimba, Xylophone, TubularBells, Dulcimer, DrawbarOrgan, PercussiveOrgan, RockOrgan, ChurchOrgan, ReedOrgan, Accordion, Harmonica, TangoAccordion, AcousticGuitarNylon, AcousticGuitarSteel, ElectricGuitarJazz, ElectricGuitarClean, ElectricGuitarMuted, OverdrivenGuitar, DistortionGuitar, GuitarHarmonics, AcousticBass, ElectricBassFinger, ElectricBassPick, FretlessBass, SlapBass1, SlapBass2, SynthBass1, SynthBass2, Violin, Viola, Cello, Contrabass, TremoloStrings, PizzicatoStrings, OrchestralHarp, Timpani, StringEnsemble1, StringEnsemble2, SynthStrings1, SynthStrings2, ChoirAahs, VoiceOohs, SynthVoice, OrchestraHit, Trumpet, Trombone, Tuba, MutedTrumpet, FrenchHorn, BrassSection, SynthBrass1, SynthBrass2, SopranoSax, AltoSax, TenorSax, BaritoneSax, Oboe, EnglishHorn, Bassoon, Clarinet, Piccolo, Flute, Recorder, PanFlute, BlownBottle, Shakuhachi, Whistle, Ocarina, Lead1Square, Lead2Sawtooth, Lead3Calliope, Lead4Chiff, Lead5Charang, Lead6Voice, Lead7Fifths, Lead8BassAndLead, Pad1NewAge, Pad2Warm, Pad3Polysynth, Pad4Choir, Pad5Bowed, Pad6Metallic, Pad7Halo, Pad8Sweep, Fx1Rain, Fx2Soundtrack, Fx3Crystal, Fx4Atmosphere, Fx5Brightness, Fx6Goblins, Fx7Echoes, Fx8SciFi, Sitar, Banjo, Shamisen, Koto, Kalimba, BagPipe, Fiddle, Shanai, TinkleBell, Agogo, SteelDrums, Woodblock, TaikoDrum, MelodicTom, SynthDrum, ReverseCymbal, GuitarFretNoise, BreathNoise, Seashore, BirdTweet, TelephoneRing, Helicopter, Applause, Gunshot
    }

}

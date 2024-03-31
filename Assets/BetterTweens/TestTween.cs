// using System;
// using UnityEngine;
//
// namespace Better.Tweens.Runtime
// {
//     public class TestTween : Tween<float>
//     {
//         
//         
//         protected override float FindRelativeFrom(float to, float options)
//         {
//             return to - options;
//         }
//
//         protected override float FindTo(float from, float options, OptionsMode optionsMode)
//         {
//             return optionsMode switch
//             {
//                 OptionsMode.To => options,
//                 OptionsMode.Relative => from + options,
//                 OptionsMode.SpeedBased => from + options * Properties.Duration,
//                 _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null) // return default?
//             };
//         }
//
//         protected override float GetRelativeOptions(float from, float to)
//         {
//             return to - from;
//         }
//         
//         protected override void EvaluateState(float time)
//         {
//             var val = Mathf.Lerp(FromValue, ToValue, time);
//             Debug.Log($"val: {val}, c_loops: {CompletedLoops}\ntime: {time}");
//         }
//     }
// }
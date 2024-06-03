using System;
using System.Numerics;
using Better.Attributes.Runtime.Select;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Video;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Matrix4x4 = UnityEngine.Matrix4x4;
using Plane = UnityEngine.Plane;
using Quaternion = UnityEngine.Quaternion;
using Slider = UnityEngine.UI.Slider;
using Toggle = UnityEngine.UI.Toggle;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace Better.Tweens.Runtime
{
    public class SSSSSSSSSSSS
    {
        [Select]
        [SerializeField] private float _float;

        private void BaseTypes()
        {
            // string l_string;
            // char l_char;
            // byte l_byte;
            // sbyte l_sbyte;
            // double l_double;
            // long l_long;
            // short l_short;
            // ulong l_ulong;
            // ushort l_ushort;
            // decimal l_decimal;
            // uint l_uint;
            // Matrix4x4 l_Matrix4x4;
            // Bounds l_Bounds;
            // Plane l_Plane;
            // RectInt l_RectInt;
            // Color32 l_Color32;
            // Gradient l_Gradient;
            // Rect l_Rect;
            // Enum l_Enum;

            int l_int;
            float l_float;
            bool l_bool;
            Color l_Color;
            Quaternion l_Quaternion;
            Vector2 l_Vector2;
            Vector2Int l_Vector2Int; // l_Vector2  with "casted" to integers
            Vector3 l_Vector3;
            Vector3Int l_Vector3Int; // l_Vector3  with "casted" to integers
            Vector4 l_Vector4;
        }

        private void DO_Instances()
        {
        }

        private void DO_Static()
        {
            VirtualTweening.Create(() => Time.timeScale, value => Time.timeScale = value)
                .From(1f)
                .Play();
        }

        private void Components()
        {
            // MonoBehaviour l_MonoBehaviour = default;

            GameObject l_GameObject = default;
            l_GameObject.SetActive(true);
            l_GameObject.Destroy(); // +delay

            Component l_Component = default;
            l_Component.Destroy(); // +delay

            Behaviour l_Behaviour = default;
            l_Behaviour.enabled = true;

            Transform l_Transform = default;
            RectTransform l_RectTransform = default;
            MeshRenderer l_MeshRenderer = default;
            SkinnedMeshRenderer l_SkinnedMeshRenderer = default;
            SpriteRenderer l_SpriteRenderer = default;
            LineRenderer l_LineRenderer = default;
            TrailRenderer l_TrailRenderer = default;
            ParticleSystem ParticleSystem = default;
            Rigidbody l_Rigidbody = default;
            Rigidbody2D Rigidbody2D = default;
            Collider l_Collider = default;
            Collider2D Collider2D = default;
            CharacterController l_CharacterController = default;
            Joint Joint = default;
            AudioSource l_AudioSource = default;
            Animator Animator = default;
            Animation l_Animation = default;
            Canvas Canvas = default;
            CanvasRenderer l_CanvasRenderer = default;
            Image Image = default;
            Text l_Text = default;
            Button Button = default;
            Slider l_Slider = default;
            Toggle Toggle = default;
            InputField l_InputField = default;
            Dropdown Dropdown = default;
            ScrollRect l_ScrollRect = default;
            VideoPlayer l_VideoPlayer = default;
            Camera l_Camera = default;
            Light Light = default;
            Projector l_Projector = default;
            CanvasGroup l_CanvasGroup = default;
            WheelCollider l_WheelCollider = default;
            Avatar Avatar = default;
            AvatarMask l_AvatarMask = default;
            Mask Mask = default;
            RectMask2D l_RectMask2D = default;
            RawImage RawImage = default;
            LayoutElement l_LayoutElement = default;
            ContentSizeFitter ContentSizeFitter = default;
            AspectRatioFitter l_AspectRatioFitter = default;
            CanvasScaler CanvasScaler = default;
            Skybox l_Skybox = default;
            WindZone WindZone = default;
            Terrain l_Terrain = default;
            MeshFilter MeshFilter = default;
            MeshCollider l_MeshCollider = default;
            Projector Projector = default;
            ReflectionProbe l_ReflectionProbe = default;
            LightProbeGroup LightProbeGroup = default;
            ConfigurableJoint l_ConfigurableJoint = default;
            CharacterJoint CharacterJoint = default;
            FixedJoint l_FixedJoint = default;
            HingeJoint HingeJoint = default;
            SpringJoint l_SpringJoint = default;
            WheelCollider WheelCollider = default;
            TerrainCollider l_TerrainCollider = default;
            AudioSource AudioSource = default;
            AudioListener l_AudioListener = default;
            AudioEchoFilter AudioEchoFilter = default;
            AudioReverbZone l_AudioReverbZone = default;
            ScrollView ScrollView = default;
            GridLayoutGroup l_GridLayoutGroup = default;
            HorizontalLayoutGroup HorizontalLayoutGroup = default;
            VerticalLayoutGroup l_VerticalLayoutGroup = default;
            LayoutGroup LayoutGroup = default;
            VideoClip l_VideoClip = default;
            VideoPlayer VideoPlayer = default;
            LODGroup l_LODGroup = default;
            BillboardRenderer BillboardRenderer = default;
            Tree l_Tree = default;
            Terrain Terrain = default;
            ScriptableObject ScriptableObject = default;
        }
    }
}
﻿using Microsoft.Xna.Framework;

namespace Conesoft.Game
{
    public abstract class Camera : Object3D
    {
        public abstract Vector3 Target { get; set; }
        public Vector3 Up { get; set; }
        public float FieldOFView { get; set; }
        public float NearCutOff { get; set; }
        public float FarCutOff { get; set; }
    }
}
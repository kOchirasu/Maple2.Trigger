namespace Maple2.Trigger._52100041_qd {
    public static class _move {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028, 9029, 9030});
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{11000001}, state: 1);
                context.SetTimer(timerId: "60", seconds: 60, autoRemove: false, display: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State보물상자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보물상자 : TriggerState {
            internal State보물상자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000001}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new StateRandom블록1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록1 : TriggerState {
            internal StateRandom블록1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new StateRandom블록2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록2 : TriggerState {
            internal StateRandom블록2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new StateRandom블록3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록3 : TriggerState {
            internal StateRandom블록3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{108})) {
                    return new StateRandom블록4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록4 : TriggerState {
            internal StateRandom블록4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{109})) {
                    return new StateRandom블록5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록5 : TriggerState {
            internal StateRandom블록5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3080, 3081, 3082, 3083, 3084, 3085}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{110})) {
                    // return new StateRandom블록6(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

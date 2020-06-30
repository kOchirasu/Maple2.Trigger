using System;

namespace Maple2.Trigger._02010060_bf {
    public static class _bridge {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateNPC감지대기(context);

        private class StateNPC감지대기 : TriggerState {
            internal StateNPC감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {701}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032,
                        3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048,
                        3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064,
                        3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000918}, arg2: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new int[] {2099})) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }

                if (context.UserValue(key: "FirstPhaseEnd", value: 1)) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {701}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000918}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000918}, arg2: 0)) {
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "TruthOfKargon");
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032,
                        3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048,
                        3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064,
                        3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078
                    }, arg2: true, arg3: 0, arg4: 50, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이펙트생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트생성 : TriggerState {
            internal State이펙트생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130
                    }, arg2: true, arg3: 0, arg4: 100, arg5: 2f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
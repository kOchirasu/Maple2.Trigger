using System;

namespace Maple2.Trigger._99999909 {
    public static class _move {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {
                    9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016,
                    9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028, 9029, 9030
                });
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032,
                        3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048,
                        3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064,
                        3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080,
                        3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096,
                        3097, 3098, 3099, 3100
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {11000001}, arg2: 1);
                context.SetTimer(arg1: "60", arg2: 60, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.State = new State보물상자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보물상자 : TriggerState {
            internal State보물상자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000001}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "105")) {
                    context.State = new State랜덤블록1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록1 : TriggerState {
            internal State랜덤블록1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054}, arg2: true,
                    arg3: 4, arg4: 0, arg5: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "106")) {
                    context.State = new State랜덤블록2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록2 : TriggerState {
            internal State랜덤블록2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063},
                    arg2: true, arg3: 4, arg4: 0, arg5: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "107")) {
                    context.State = new State랜덤블록3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록3 : TriggerState {
            internal State랜덤블록3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072},
                    arg2: true, arg3: 4, arg4: 0, arg5: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "108")) {
                    context.State = new State랜덤블록4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록4 : TriggerState {
            internal State랜덤블록4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080}, arg2: true,
                    arg3: 4, arg4: 0, arg5: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "109")) {
                    context.State = new State랜덤블록5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤블록5 : TriggerState {
            internal State랜덤블록5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3080, 3081, 3082, 3083, 3084, 3085}, arg2: true, arg3: 4,
                    arg4: 0, arg5: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "110")) {
                    // context.State = new State랜덤블록6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
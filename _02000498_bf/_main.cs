using System;

namespace Maple2.Trigger._02000498_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {500}, arg2: true);
                context.SetEffect(arg1: new int[] {501}, arg2: true);
                context.SetEffect(arg1: new int[] {600}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {6010}, arg2: false);
                context.SetEffect(arg1: new int[] {6011}, arg2: false);
                context.SetEffect(arg1: new int[] {6012}, arg2: false);
                context.SetEffect(arg1: new int[] {6013}, arg2: false);
                context.SetEffect(arg1: new int[] {6015}, arg2: false);
                context.SetEffect(arg1: new int[] {6016}, arg2: false);
                context.SetEffect(arg1: new int[] {6017}, arg2: false);
                context.SetEffect(arg1: new int[] {6018}, arg2: false);
                context.SetEffect(arg1: new int[] {6019}, arg2: false);
                context.SetEffect(arg1: new int[] {6020}, arg2: false);
                context.SetEffect(arg1: new int[] {6021}, arg2: false);
                context.SetEffect(arg1: new int[] {6022}, arg2: false);
                context.SetEffect(arg1: new int[] {6023}, arg2: false);
                context.SetEffect(arg1: new int[] {6024}, arg2: false);
                context.SetEffect(arg1: new int[] {6025}, arg2: false);
                context.SetEffect(arg1: new int[] {6026}, arg2: false);
                context.SetEffect(arg1: new int[] {6027}, arg2: false);
                context.SetEffect(arg1: new int[] {6028}, arg2: false);
                context.SetEffect(arg1: new int[] {6029}, arg2: false);
                context.SetEffect(arg1: new int[] {6030}, arg2: false);
                context.SetEffect(arg1: new int[] {6031}, arg2: false);
                context.SetEffect(arg1: new int[] {6032}, arg2: false);
                context.SetEffect(arg1: new int[] {6110}, arg2: false);
                context.SetEffect(arg1: new int[] {6111}, arg2: false);
                context.SetEffect(arg1: new int[] {6112}, arg2: false);
                context.SetEffect(arg1: new int[] {6113}, arg2: false);
                context.SetEffect(arg1: new int[] {6101}, arg2: false);
                context.SetSkill(arg1: new int[] {701}, arg2: false);
                context.SetSkill(arg1: new int[] {702}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100009})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {100009}, arg2: 70000102, arg3: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100001})) {
                    context.State = new State시작연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출 : TriggerState {
            internal State시작연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6011}, arg2: true);
                context.SetEffect(arg1: new int[] {6012}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "다크스크림의 새로운 차원의 틈으로 진입 했습니다.", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100002})) {
                    context.State = new State시작연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_2 : TriggerState {
            internal State시작연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6013}, arg2: true);
                context.SetEffect(arg1: new int[] {6010}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100003})) {
                    context.State = new State시작연출_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_3 : TriggerState {
            internal State시작연출_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6023}, arg2: true);
                context.SetEffect(arg1: new int[] {6022}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100004})) {
                    context.State = new State시작연출_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_4 : TriggerState {
            internal State시작연출_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6021}, arg2: true);
                context.SetEffect(arg1: new int[] {6024}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "더 가까이 다가가십시오.", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {500}, arg2: false);
                context.SetEffect(arg1: new int[] {501}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100005})) {
                    context.State = new State시작연출_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_5 : TriggerState {
            internal State시작연출_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6028}, arg2: true);
                context.SetEffect(arg1: new int[] {6027}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100006})) {
                    context.State = new State시작연출_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_6 : TriggerState {
            internal State시작연출_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6025}, arg2: true);
                context.SetEffect(arg1: new int[] {6026}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100007})) {
                    context.State = new State시작연출_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_7 : TriggerState {
            internal State시작연출_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6032}, arg2: true);
                context.SetEffect(arg1: new int[] {6029}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100008})) {
                    context.State = new State시작연출_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작연출_8 : TriggerState {
            internal State시작연출_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6031}, arg2: true);
                context.SetEffect(arg1: new int[] {6030}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
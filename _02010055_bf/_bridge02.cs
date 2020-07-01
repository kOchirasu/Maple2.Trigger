namespace Maple2.Trigger._02010055_bf {
    public static class _bridge02 {
        public class StateNPC감지대기 : TriggerState {
            internal StateNPC감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: false);
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000919}, arg2: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {2099})) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }

                if (context.GetUserValue(key: "SecondPhaseEnd") == 1) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000919}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000919}, arg2: 0)) {
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243
                    }, arg2: true, arg3: 0, arg4: 50, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                    arg1: new[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319
                    }, arg2: true, arg3: 0, arg4: 100, arg5: 2f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
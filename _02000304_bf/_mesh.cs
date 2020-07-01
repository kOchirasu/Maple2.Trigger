namespace Maple2.Trigger._02000304_bf {
    public static class _mesh {
        public class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4101, 4102, 4103, 4104, 4105, 4106, 4107, 4108, 4109, 4110, 4111, 4112, 4113, 4114, 4115, 4116, 4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212, 4213, 4214, 4215, 4216, 4301, 4302, 4303, 4304, 4305, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4401, 4402, 4403, 4404, 4405, 4406, 4407, 4408, 4409, 4410, 4411, 4412, 4413, 4414, 4415, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State패턴01랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01랜덤 : TriggerState {
            internal State패턴01랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴01_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴01_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴01_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴01_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01_A : TriggerState {
            internal State패턴01_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3204}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4204}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴01종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01_B : TriggerState {
            internal State패턴01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3303}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3402}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4303}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4402}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴01종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01_C : TriggerState {
            internal State패턴01_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴01종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01_D : TriggerState {
            internal State패턴01_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴01종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01종료 : TriggerState {
            internal State패턴01종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02시작 : TriggerState {
            internal State패턴02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State패턴02랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02랜덤 : TriggerState {
            internal State패턴02랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴02_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴02_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴02_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴02_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02_A : TriggerState {
            internal State패턴02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3301}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3404}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4301}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4404}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴02종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02_B : TriggerState {
            internal State패턴02_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴02종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02_C : TriggerState {
            internal State패턴02_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴02종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02_D : TriggerState {
            internal State패턴02_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4107}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3107}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3206}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4107}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4206}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴02종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02종료 : TriggerState {
            internal State패턴02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴03시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03시작 : TriggerState {
            internal State패턴03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴03랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03랜덤 : TriggerState {
            internal State패턴03랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴03_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴03_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴03_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴03_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03_A : TriggerState {
            internal State패턴03_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3204, 3213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304, 3313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4204, 4213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304, 4313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴03종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03_B : TriggerState {
            internal State패턴03_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4106, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4207, 4210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307, 4310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3106, 3111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3207, 3210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3307, 3310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3406, 3411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4106, 4111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4207, 4210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4307, 4310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4406, 4411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴03종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03_C : TriggerState {
            internal State패턴03_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4103, 4114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3103, 3114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3202, 3215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3302, 3315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3403, 3414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4103, 4114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4202, 4215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4302, 4315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4403, 4414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴03종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03_D : TriggerState {
            internal State패턴03_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4108, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4205, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4407, 4409}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3108, 3110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3205, 3211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3306, 3312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3407, 3409}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4108, 4110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4205, 4211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4306, 4312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4407, 4409}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴03종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03종료 : TriggerState {
            internal State패턴03종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴04시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04시작 : TriggerState {
            internal State패턴04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴04랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04랜덤 : TriggerState {
            internal State패턴04랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴04_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴04_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴04_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴04_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04_A : TriggerState {
            internal State패턴04_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3112, 3115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3209, 3214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3303, 3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3402, 3415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4112, 4115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4209, 4214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4303, 4308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4402, 4415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴04종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04_B : TriggerState {
            internal State패턴04_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104, 3113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3301, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3404, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104, 4113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4301, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4404, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴04종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04_C : TriggerState {
            internal State패턴04_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3102, 3114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3203, 3215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3302, 3314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3403, 3415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4102, 4114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4203, 4215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4302, 4314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4403, 4415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴04종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04_D : TriggerState {
            internal State패턴04_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4405}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3112, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3209, 3213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304, 3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3405}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4112, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4209, 4213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304, 4308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4405}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴04종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04종료 : TriggerState {
            internal State패턴04종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴05시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05시작 : TriggerState {
            internal State패턴05시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴05랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05랜덤 : TriggerState {
            internal State패턴05랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴05_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴05_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴05_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴05_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05_A : TriggerState {
            internal State패턴05_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4106, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4207, 4210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307, 4310, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4411, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3106, 3111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3204, 3207, 3210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3307, 3310, 3313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3406, 3411, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4106, 4111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4204, 4207, 4210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4307, 4310, 4313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4406, 4411, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴05종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05_B : TriggerState {
            internal State패턴05_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4407, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104, 3107, 3110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3206, 3211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3306, 3311, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3407, 3410, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104, 4107, 4110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4206, 4211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4306, 4311, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4407, 4410, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴05종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05_C : TriggerState {
            internal State패턴05_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4104, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4204, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4313, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4413, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3104, 3113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3204, 3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3301, 3313, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3404, 3413, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4104, 4113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4204, 4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4301, 4313, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4404, 4413, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴05종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05_D : TriggerState {
            internal State패턴05_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4103, 4106, 4108}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4205, 4207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4310, 4312, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4409, 4411, 4414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3103, 3106, 3108}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3202, 3205, 3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3310, 3312, 3315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3409, 3411, 3414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4103, 4106, 4108}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4202, 4205, 4207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4310, 4312, 4315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4409, 4411, 4414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴05종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴05종료 : TriggerState {
            internal State패턴05종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴06시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06시작 : TriggerState {
            internal State패턴06시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴06랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06랜덤 : TriggerState {
            internal State패턴06랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴06_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴06_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴06_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴06_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06_A : TriggerState {
            internal State패턴06_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4308, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4405, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104, 3107, 3112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3206, 3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3308, 3311, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3405, 3410, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104, 4107, 4112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4206, 4209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4308, 4311, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4405, 4410, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴06종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06_B : TriggerState {
            internal State패턴06_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4115, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4213, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4304, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4402, 4405}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3112, 3115, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3209, 3213, 3214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3303, 3304, 3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3402, 3405}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4112, 4115, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4209, 4213, 4214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4303, 4304, 4308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4402, 4405}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴06종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06_C : TriggerState {
            internal State패턴06_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4102, 4105}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4204, 4208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4309, 4313, 4314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4412, 4415, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3105}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3203, 3204, 3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3309, 3313, 3314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3412, 3415, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4102, 4105}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4203, 4204, 4208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4309, 4313, 4314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4412, 4415, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴06종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06_D : TriggerState {
            internal State패턴06_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4107, 4109, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206, 4212, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4308, 4310, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4405, 4411, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3107, 3109, 3115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3206, 3212, 3214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3308, 3310, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3405, 3411, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4107, 4109, 4115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4206, 4212, 4214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4308, 4310, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4405, 4411, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴06종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴06종료 : TriggerState {
            internal State패턴06종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴07시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07시작 : TriggerState {
            internal State패턴07시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴07랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07랜덤 : TriggerState {
            internal State패턴07랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_A(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_B(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_C(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_D(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_E(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_F(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_G(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_H(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_I(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State패턴07_J(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_A : TriggerState {
            internal State패턴07_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4106, 4111, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4207, 4210, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4307, 4310, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4406, 4411, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3106, 3111, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3204, 3207, 3210, 3213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304, 3307, 3310, 3313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3406, 3411, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4106, 4111, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4204, 4207, 4210, 4213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304, 4307, 4310, 4313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4406, 4411, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_B : TriggerState {
            internal State패턴07_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4110, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4211, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4306, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4407, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104, 3107, 3110, 3113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3206, 3211, 3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3301, 3306, 3311, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3404, 3407, 3410, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104, 4107, 4110, 4113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4206, 4211, 4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4301, 4306, 4311, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4404, 4407, 4410, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_C : TriggerState {
            internal State패턴07_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4105, 4107, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4206, 4208, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4305, 4307, 4310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4406, 4408, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3102, 3105, 3107, 3110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3203, 3206, 3208, 3211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3302, 3305, 3307, 3310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3403, 3406, 3408, 3411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4102, 4105, 4107, 4110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4203, 4206, 4208, 4211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4302, 4305, 4307, 4310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4403, 4406, 4408, 4411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_D : TriggerState {
            internal State패턴07_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4109, 4111, 4114, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4211, 4214, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4309, 4311, 4314, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4409, 4411, 4414, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3109, 3111, 3114, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3209, 3211, 3214, 3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3309, 3311, 3314, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3409, 3411, 3414, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4109, 4111, 4114, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4209, 4211, 4214, 4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4309, 4311, 4314, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4409, 4411, 4414, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_E : TriggerState {
            internal State패턴07_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4104, 4113, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4204, 4213, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4304, 4313, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4404, 4413, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3101, 3104, 3113, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3204, 3213, 3216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3301, 3304, 3313, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3404, 3413, 3416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4101, 4104, 4113, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4204, 4213, 4216}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4301, 4304, 4313, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4404, 4413, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_F : TriggerState {
            internal State패턴07_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4106, 4107, 4110, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206, 4207, 4210, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4307, 4310, 4311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4407, 4410, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3106, 3107, 3110, 3111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3206, 3207, 3210, 3211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3306, 3307, 3310, 3311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3406, 3407, 3410, 3411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4106, 4107, 4110, 4111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4206, 4207, 4210, 4211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4306, 4307, 4310, 4311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4406, 4407, 4410, 4411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_G : TriggerState {
            internal State패턴07_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4111, 4112, 4115, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4210, 4213, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4304, 4307, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4402, 4405, 4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3111, 3112, 3115, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3209, 3210, 3213, 3214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3303, 3304, 3307, 3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3402, 3405, 3406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4111, 4112, 4115, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4209, 4210, 4213, 4214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4303, 4304, 4307, 4308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4402, 4405, 4406}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_H : TriggerState {
            internal State패턴07_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4103, 4114, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4203, 4214, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4303, 4314, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402, 4403, 4414, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3102, 3103, 3114, 3115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3202, 3203, 3214, 3215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3302, 3303, 3314, 3315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3402, 3403, 3414, 3415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4102, 4103, 4114, 4115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4202, 4203, 4214, 4215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4302, 4303, 4314, 4315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4402, 4403, 4414, 4415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_I : TriggerState {
            internal State패턴07_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4108, 4112, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4205, 4209, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4308, 4312, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4405, 4409, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3104, 3108, 3112, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3201, 3205, 3209, 3213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3304, 3308, 3312, 3316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3405, 3409, 3413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4104, 4108, 4112, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4201, 4205, 4209, 4213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4304, 4308, 4312, 4316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4405, 4409, 4413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07_J : TriggerState {
            internal State패턴07_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4108, 4111, 4114, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4205, 4210, 4213, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4304, 4307, 4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4403, 4406, 4409}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3108, 3111, 3114, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3205, 3210, 3213, 3215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3302, 3304, 3307, 3312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {3401, 3403, 3406, 3409}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4108, 4111, 4114, 4116}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4205, 4210, 4213, 4215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4302, 4304, 4307, 4312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {4401, 4403, 4406, 4409}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State패턴07종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴07종료 : TriggerState {
            internal State패턴07종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State패턴07시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
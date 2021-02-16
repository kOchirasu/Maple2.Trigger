namespace Maple2.Trigger._02000304_bf {
    public static class _mesh {
        public class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4101, 4102, 4103, 4104, 4105, 4106, 4107, 4108, 4109, 4110, 4111, 4112, 4113, 4114, 4115, 4116, 4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212, 4213, 4214, 4215, 4216, 4301, 4302, 4303, 4304, 4305, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4401, 4402, 4403, 4404, 4405, 4406, 4407, 4408, 4409, 4410, 4411, 4412, 4413, 4414, 4415, 4416}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StatePattern01Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Random : TriggerState {
            internal StatePattern01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern01_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern01_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern01_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern01_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01_A : TriggerState {
            internal StatePattern01_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01_B : TriggerState {
            internal StatePattern01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01_C : TriggerState {
            internal StatePattern01_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01_D : TriggerState {
            internal StatePattern01_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01종료 : TriggerState {
            internal StatePattern01종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02시작 : TriggerState {
            internal StatePattern02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StatePattern02Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Random : TriggerState {
            internal StatePattern02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern02_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern02_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern02_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern02_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02_A : TriggerState {
            internal StatePattern02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02_B : TriggerState {
            internal StatePattern02_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02_C : TriggerState {
            internal StatePattern02_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02_D : TriggerState {
            internal StatePattern02_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4107}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02종료 : TriggerState {
            internal StatePattern02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03시작 : TriggerState {
            internal StatePattern03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern03Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Random : TriggerState {
            internal StatePattern03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern03_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern03_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern03_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern03_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03_A : TriggerState {
            internal StatePattern03_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03_B : TriggerState {
            internal StatePattern03_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4106, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4207, 4210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307, 4310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03_C : TriggerState {
            internal StatePattern03_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4103, 4114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03_D : TriggerState {
            internal StatePattern03_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4108, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4205, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4407, 4409}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03종료 : TriggerState {
            internal StatePattern03종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern04시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04시작 : TriggerState {
            internal StatePattern04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern04Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Random : TriggerState {
            internal StatePattern04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern04_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern04_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern04_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern04_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04_A : TriggerState {
            internal StatePattern04_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04_B : TriggerState {
            internal StatePattern04_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04_C : TriggerState {
            internal StatePattern04_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04_D : TriggerState {
            internal StatePattern04_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4405}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04종료 : TriggerState {
            internal StatePattern04종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern05시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05시작 : TriggerState {
            internal StatePattern05시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern05Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05Random : TriggerState {
            internal StatePattern05Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern05_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern05_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern05_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern05_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05_A : TriggerState {
            internal StatePattern05_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4106, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4207, 4210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4307, 4310, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4411, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern05종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05_B : TriggerState {
            internal StatePattern05_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4407, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern05종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05_C : TriggerState {
            internal StatePattern05_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4104, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4204, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4313, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4413, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern05종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05_D : TriggerState {
            internal StatePattern05_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4103, 4106, 4108}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4205, 4207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4310, 4312, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4409, 4411, 4414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern05종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern05종료 : TriggerState {
            internal StatePattern05종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern06시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06시작 : TriggerState {
            internal StatePattern06시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern06Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06Random : TriggerState {
            internal StatePattern06Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern06_A(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern06_B(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern06_C(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern06_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06_A : TriggerState {
            internal StatePattern06_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4308, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4405, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern06종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06_B : TriggerState {
            internal StatePattern06_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4112, 4115, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4213, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4304, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4402, 4405}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern06종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06_C : TriggerState {
            internal StatePattern06_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4102, 4105}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4204, 4208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4309, 4313, 4314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4412, 4415, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern06종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06_D : TriggerState {
            internal StatePattern06_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4107, 4109, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206, 4212, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4308, 4310, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4405, 4411, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern06종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern06종료 : TriggerState {
            internal StatePattern06종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern07시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07시작 : TriggerState {
            internal StatePattern07시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern07Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07Random : TriggerState {
            internal StatePattern07Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_A(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_B(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_C(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_D(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_E(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_F(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_G(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_H(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_I(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StatePattern07_J(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_A : TriggerState {
            internal StatePattern07_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4106, 4111, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4204, 4207, 4210, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4307, 4310, 4313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4406, 4411, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_B : TriggerState {
            internal StatePattern07_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4107, 4110, 4113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4206, 4211, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4306, 4311, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4404, 4407, 4410, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_C : TriggerState {
            internal StatePattern07_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4105, 4107, 4110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4203, 4206, 4208, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4305, 4307, 4310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4403, 4406, 4408, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_D : TriggerState {
            internal StatePattern07_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4109, 4111, 4114, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4211, 4214, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4309, 4311, 4314, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4409, 4411, 4414, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_E : TriggerState {
            internal StatePattern07_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4101, 4104, 4113, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4204, 4213, 4216}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4301, 4304, 4313, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4404, 4413, 4416}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_F : TriggerState {
            internal StatePattern07_F(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4106, 4107, 4110, 4111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4206, 4207, 4210, 4211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4306, 4307, 4310, 4311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4406, 4407, 4410, 4411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_G : TriggerState {
            internal StatePattern07_G(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4111, 4112, 4115, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4209, 4210, 4213, 4214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4303, 4304, 4307, 4308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4402, 4405, 4406}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_H : TriggerState {
            internal StatePattern07_H(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4102, 4103, 4114, 4115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4202, 4203, 4214, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4303, 4314, 4315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4402, 4403, 4414, 4415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_I : TriggerState {
            internal StatePattern07_I(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4104, 4108, 4112, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4201, 4205, 4209, 4213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4304, 4308, 4312, 4316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4405, 4409, 4413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07_J : TriggerState {
            internal StatePattern07_J(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4108, 4111, 4114, 4116}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4205, 4210, 4213, 4215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4302, 4304, 4307, 4312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {4401, 4403, 4406, 4409}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
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
                    return new StatePattern07종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern07종료 : TriggerState {
            internal StatePattern07종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StatePattern07시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(id: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
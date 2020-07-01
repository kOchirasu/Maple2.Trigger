namespace Maple2.Trigger._02020112_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: 0f);
                context.SetUserValue(triggerId: 99990002, key: "JumpFloor", value: 0);
                context.SetUserValue(triggerId: 99990017, key: "JumpFloor", value: 0);
                context.SetActor(arg1: 9901, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9902, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9903, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9904, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State중력방_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_대기 : TriggerState {
            internal State중력방_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {915})) {
                    return new State중력방_발판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_발판 : TriggerState {
            internal State중력방_발판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990020, key: "GravityRoom", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GravityRoom") == 2) {
                    return new State중력방_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_전투 : TriggerState {
            internal State중력방_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {141, 142, 143, 144})) {
                    return new State카메라_발판점프대(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라_발판점프대 : TriggerState {
            internal State카메라_발판점프대(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.SetUserValue(triggerId: 99990020, key: "GravityRoom", value: 1);
                context.SetUserValue(triggerId: 99990002, key: "JumpFloor", value: 1);
                context.SetUserValue(triggerId: 99990017, key: "JumpFloor", value: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {611, 612}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State카메라_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라_종료 : TriggerState {
            internal State카메라_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130})) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: false);
                    return new State격리방_지하(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_지하 : TriggerState {
            internal State격리방_지하(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterDead") == 1) {
                    return new State격리방_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_대기 : TriggerState {
            internal State격리방_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {932})) {
                    return new State격리방_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_전투 : TriggerState {
            internal State격리방_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {191}, arg2: false);
                context.SetUserValue(triggerId: 99990008, key: "Start", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {191})) {
                    context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                    context.SetUserValue(triggerId: 99990008, key: "Start", value: 2);
                    context.SetUserValue(triggerId: 99990013, key: "EliteDead", value: 1);
                    context.SetUserValue(triggerId: 99990014, key: "EliteDead", value: 1);
                    context.SetUserValue(triggerId: 99990015, key: "EliteDead", value: 1);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
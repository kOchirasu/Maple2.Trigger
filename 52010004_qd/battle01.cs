namespace Maple2.Trigger._52010004_qd {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {10000, 10001, 10002, 10003}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002800}, arg3: new byte[] {2})) {
                    return new State둔바교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체01 : TriggerState {
            internal State둔바교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State둔바SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바SetupCinematic01 : TriggerState {
            internal State둔바SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State둔바대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화01 : TriggerState {
            internal State둔바대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, script: "$52010004_QD__BATTLE01__0$", arg4: 2);
                context.SetSkip(state: new State둔바대화02Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State둔바대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화02Wait : TriggerState {
            internal State둔바대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State둔바대화02(context);
            }

            public override void OnExit() { }
        }

        private class State둔바대화02 : TriggerState {
            internal State둔바대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, script: "$52010004_QD__BATTLE01__1$", arg4: 2);
                context.SetSkip(state: new State둔바대화03Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State둔바대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화03Wait : TriggerState {
            internal State둔바대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State둔바대화03(context);
            }

            public override void OnExit() { }
        }

        private class State둔바대화03 : TriggerState {
            internal State둔바대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "12", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, script: "$52010004_QD__BATTLE01__2$", arg4: 2);
                context.SetSkip(state: new State둔바StopCinematic01(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State둔바StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바StopCinematic01 : TriggerState {
            internal State둔바StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(id: "13", arg2: 1);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new State전투Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare01 : TriggerState {
            internal State전투Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "20", arg2: 1);
                context.SetAgent(arg1: new[] {10000, 10001, 10002, 10003}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State전투중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010004, arg2: 50, arg3: 9000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    return new State둔바교체Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체Wait02 : TriggerState {
            internal State둔바교체Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(id: "30", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State둔바교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체02 : TriggerState {
            internal State둔바교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
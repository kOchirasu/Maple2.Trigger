namespace Maple2.Trigger._52010008_qd {
    public static class _catchjailbreaker01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903, 904, 905, 906}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000851}, arg2: 0);
                context.SetMesh(arg1: new[] {6000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State전투안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투안내01 : TriggerState {
            internal State전투안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 100, textId: 40010);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906})) {
                    return new State죄수찾기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수찾기01 : TriggerState {
            internal State죄수찾기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 100);
                context.SetInteractObject(arg1: new[] {10000851}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000851}, arg2: 0)) {
                    return new State죄수Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수Spawn01 : TriggerState {
            internal State죄수Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "11", arg2: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1010");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State죄수Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수Spawn02 : TriggerState {
            internal State죄수Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2010");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State벨마Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn01 : TriggerState {
            internal State벨마Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 1);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State벨마대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화01 : TriggerState {
            internal State벨마대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__0$", arg4: 3);
                context.SetSkip(state: new State벨마대화02Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State벨마대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화02Wait : TriggerState {
            internal State벨마대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State벨마대화02(context);
            }

            public override void OnExit() { }
        }

        private class State벨마대화02 : TriggerState {
            internal State벨마대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__1$", arg4: 3);
                context.SetSkip(state: new State벨마대화03Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new State벨마대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화03Wait : TriggerState {
            internal State벨마대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State벨마대화03(context);
            }

            public override void OnExit() { }
        }

        private class State벨마대화03 : TriggerState {
            internal State벨마대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__2$", arg4: 3);
                context.SetSkip(state: new State벨마StopCinematic01(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    return new State벨마StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마StopCinematic01 : TriggerState {
            internal State벨마StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "30", arg2: 1);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "catchjailbreaker");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State유저이동Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동Prepare : TriggerState {
            internal State유저이동Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new State유저이동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동시작 : TriggerState {
            internal State유저이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02010019, arg2: 2, arg3: 9000);
                context.DestroyMonster(arg1: new[] {101, 201, 301, 901, 902, 903, 904, 905, 906});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
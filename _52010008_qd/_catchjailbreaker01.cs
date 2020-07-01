namespace Maple2.Trigger._52010008_qd {
    public static class _catchjailbreaker01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903, 904, 905, 906}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000851}, arg2: 0);
                context.SetMesh(arg1: new[] {6000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State전투안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투안내01 : TriggerState {
            internal State전투안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 100, textId: 40010);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906})) {
                    context.State = new State죄수찾기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State죄수찾기01 : TriggerState {
            internal State죄수찾기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 100);
                context.SetInteractObject(arg1: new[] {10000851}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000851}, arg2: 0)) {
                    context.State = new State죄수등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State죄수등장01 : TriggerState {
            internal State죄수등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "11", arg2: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1010");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State죄수등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State죄수등장02 : TriggerState {
            internal State죄수등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2010");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State벨마등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장01 : TriggerState {
            internal State벨마등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 1);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State벨마대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마대화01 : TriggerState {
            internal State벨마대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__0$", arg4: 3);
                context.SetSkip(arg1: "벨마대화02대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State벨마대화02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마대화02대기 : TriggerState {
            internal State벨마대화02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State벨마대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마대화02 : TriggerState {
            internal State벨마대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__1$", arg4: 3);
                context.SetSkip(arg1: "벨마대화03대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State벨마대화03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마대화03대기 : TriggerState {
            internal State벨마대화03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State벨마대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마대화03 : TriggerState {
            internal State벨마대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11000521, arg3: "$52010008_QD__CATCHJAILBREAKER01__2$", arg4: 3);
                context.SetSkip(arg1: "벨마연출종료01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State벨마연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마연출종료01 : TriggerState {
            internal State벨마연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "30", arg2: 1);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "catchjailbreaker");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State유저이동준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동준비 : TriggerState {
            internal State유저이동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State유저이동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동시작 : TriggerState {
            internal State유저이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02010019, arg2: 2, arg3: 9000);
                context.DestroyMonster(arg1: new[] {101, 201, 301});
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
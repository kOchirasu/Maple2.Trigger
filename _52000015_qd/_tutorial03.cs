namespace Maple2.Trigger._52000015_qd {
    public static class _tutorial03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {6100}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CreateWidget(arg1: "Guide");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State퀘스트진행중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트진행중 : TriggerState {
            internal State퀘스트진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {90000414},
                    arg3: new byte[] {2})) {
                    context.State = new State딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이02 : TriggerState {
            internal State딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State딜레이03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이03 : TriggerState {
            internal State딜레이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "이슈라대화04대기CSkip", arg2: "nextState");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State순간이동준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State순간이동준비 : TriggerState {
            internal State순간이동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__0$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State순간이동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State순간이동시작 : TriggerState {
            internal State순간이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 2);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.MoveUser(arg1: 52000015, arg2: 50, arg3: 9001);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State순간이동진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State순간이동진행 : TriggerState {
            internal State순간이동진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State순간이동완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State순간이동완료 : TriggerState {
            internal State순간이동완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State적등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State적등장01 : TriggerState {
            internal State적등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 2);
                context.CreateMonster(arg1: new[] {901});
                context.CreateMonster(arg1: new[] {902});
                context.CreateMonster(arg1: new[] {903});
                context.CreateMonster(arg1: new[] {904});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State이슈라대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화01 : TriggerState {
            internal State이슈라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 3);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__1$", arg4: 3);
                context.SetSkip(arg1: "이슈라대화02대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State이슈라대화02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화02대기 : TriggerState {
            internal State이슈라대화02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이슈라대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화02 : TriggerState {
            internal State이슈라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 1);
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_902");
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_903");
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData_904");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new State변절자대화01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6001}, arg2: false);
            }
        }

        private class State변절자대화01 : TriggerState {
            internal State변절자대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001235, arg3: "$52000015_QD__TUTORIAL03__2$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State이슈라대화03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화03대기 : TriggerState {
            internal State이슈라대화03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이슈라대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화03 : TriggerState {
            internal State이슈라대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 3);
                context.SetEffect(arg1: new[] {6100}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__3$", arg4: 3);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State이슈라대화04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화04대기CSkip : TriggerState {
            internal State이슈라대화04대기CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202});
                context.MoveUser(arg1: 52000015, arg2: 50, arg3: 9001);
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이슈라대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화04대기 : TriggerState {
            internal State이슈라대화04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이슈라대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화04 : TriggerState {
            internal State이슈라대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateHP가이드01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
            }
        }

        private class StateHP가이드01 : TriggerState {
            internal StateHP가이드01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10012060);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10012070")) {
                    context.State = new State전투시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작01 : TriggerState {
            internal State전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904});
                context.CreateMonster(arg1: new[] {911, 912, 913, 914}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State전투중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State위기상황연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위기상황연출준비 : TriggerState {
            internal State위기상황연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State위기상황연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위기상황연출시작01 : TriggerState {
            internal State위기상황연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 1);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__4$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State위기상황연출시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위기상황연출시작02 : TriggerState {
            internal State위기상황연출시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 1);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State위기상황연출완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위기상황연출완료 : TriggerState {
            internal State위기상황연출완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetTimer(arg1: "23", arg2: 3);
                context.DestroyMonster(arg1: new[] {203});
                context.DestroyMonster(arg1: new[] {911, 912, 913, 914});
                context.SetEffect(arg1: new[] {6003}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State위기상황종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위기상황종료 : TriggerState {
            internal State위기상황종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.MoveUser(arg1: 63000012, arg2: 50, arg3: 9002);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5002}, arg2: false);
            }
        }
    }
}
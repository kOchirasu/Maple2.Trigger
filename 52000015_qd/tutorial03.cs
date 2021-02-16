namespace Maple2.Trigger._52000015_qd {
    public static class _tutorial03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 6000, 6001, 6100, 6002, 6003}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 201}, arg2: true);
                context.CreateWidget(arg1: "Guide");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행중 : TriggerState {
            internal StateQuest진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {90000414}, arg3: new byte[] {2})) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSceneSkip(state: new StateIshura대화04WaitCSkip(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                return new StateTeleportationPrepare(context);
            }

            public override void OnExit() { }
        }

        private class StateTeleportationPrepare : TriggerState {
            internal StateTeleportationPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateTeleportation시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation시작 : TriggerState {
            internal StateTeleportation시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 2);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.MoveUser(arg1: 52000015, arg2: 50, arg3: 9001);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateTeleportation진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation진행 : TriggerState {
            internal StateTeleportation진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateTeleportation완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation완료 : TriggerState {
            internal StateTeleportation완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetCinematicUI(arg1: 4);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State적Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State적Spawn01 : TriggerState {
            internal State적Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 2);
                context.CreateMonster(arg1: new[] {901});
                context.CreateMonster(arg1: new[] {902});
                context.CreateMonster(arg1: new[] {903});
                context.CreateMonster(arg1: new[] {904});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    return new StateIshura대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화01 : TriggerState {
            internal StateIshura대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 3);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__1$", arg4: 3);
                context.SetSkip(state: new StateIshura대화02Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    return new StateIshura대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02Wait : TriggerState {
            internal StateIshura대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateIshura대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02 : TriggerState {
            internal StateIshura대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 1);
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_902");
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_903");
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData_904");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    return new State변절자대화01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateIshura대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화03Wait : TriggerState {
            internal StateIshura대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateIshura대화03(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화03 : TriggerState {
            internal StateIshura대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 3);
                context.SetEffect(arg1: new[] {6100}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__3$", arg4: 3);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StateIshura대화04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04WaitCSkip : TriggerState {
            internal StateIshura대화04WaitCSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202});
                context.MoveUser(arg1: 52000015, arg2: 50, arg3: 9001);
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904});
            }

            public override TriggerState Execute() {
                return new StateIshura대화04(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04Wait : TriggerState {
            internal StateIshura대화04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateIshura대화04(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04 : TriggerState {
            internal StateIshura대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return new StateHPGuide01(context);
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
            }
        }

        private class StateHPGuide01 : TriggerState {
            internal StateHPGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10012060);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10012070")) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904});
                context.CreateMonster(arg1: new[] {911, 912, 913, 914}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State전투중01(context);
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State위기상황SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황SetupCinematic : TriggerState {
            internal State위기상황SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5002, 5000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State위기상황StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황StartCinematic01 : TriggerState {
            internal State위기상황StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 1);
                context.SetEffect(arg1: new[] {5000, 6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000015_QD__TUTORIAL03__4$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new State위기상황StartCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황StartCinematic02 : TriggerState {
            internal State위기상황StartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 1);
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    return new State위기상황Cinematic완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황Cinematic완료 : TriggerState {
            internal State위기상황Cinematic완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 4);
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: true);
                context.SetTimer(arg1: "23", arg2: 3);
                context.DestroyMonster(arg1: new[] {203, 911, 912, 913, 914});
                context.SetEffect(arg1: new[] {6003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    return new State위기상황종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황종료 : TriggerState {
            internal State위기상황종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
                context.MoveUser(arg1: 63000012, arg2: 50, arg3: 9002);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5002}, arg2: false);
            }
        }
    }
}
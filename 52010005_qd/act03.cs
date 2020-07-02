namespace Maple2.Trigger._52010005_qd {
    public static class _act03 {
        public class StateQuest조건03 : TriggerState {
            internal StateQuest조건03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000872}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002822}, arg3: new byte[] {1})) {
                    return new StateQ3_Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_Delay01 : TriggerState {
            internal StateQ3_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    return new StateQ3_미카Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카Appear01 : TriggerState {
            internal StateQ3_미카Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {601}, arg2: false);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_6010");
                context.DestroyMonster(arg1: new[] {401, 101});
                context.CreateMonster(arg1: new[] {501}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new StateQ3_미카연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카연출01 : TriggerState {
            internal StateQ3_미카연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 5);
                context.CameraSelectPath(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new StateQ3_미카연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카연출02 : TriggerState {
            internal StateQ3_미카연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8003, arg2: new[] {601})) {
                    return new StateQ3_미카연출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카연출03 : TriggerState {
            internal StateQ3_미카연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 4);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_6011");
                context.CameraSelectPath(arg1: new[] {2002, 2001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new StateQ3_미카연출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카연출04 : TriggerState {
            internal StateQ3_미카연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000872}, arg2: 1);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000872}, arg2: 0)) {
                    return new StateQ3_영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_영상재생 : TriggerState {
            internal StateQ3_영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "MemoryofDragon.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateQ3_시네마틱연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출01 : TriggerState {
            internal StateQ3_시네마틱연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 4);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT03__0$", arg4: 4);
                context.SetSkip(arg1: "Q3_시네마틱연출02대기");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new StateQ3_시네마틱연출02대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출02대기 : TriggerState {
            internal StateQ3_시네마틱연출02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return new StateQ3_시네마틱연출02(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출02 : TriggerState {
            internal StateQ3_시네마틱연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4001, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new StateQ3_시네마틱연출03(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출03 : TriggerState {
            internal StateQ3_시네마틱연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001316, arg3: "$52010005_QD__ACT03__1$", arg4: 3);
                context.SetSkip(arg1: "Q3_시네마틱연출04");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    return new StateQ3_시네마틱연출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출04 : TriggerState {
            internal StateQ3_시네마틱연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateQ3_시네마틱연출05(context);
            }

            public override void OnExit() { }
        }

        private class StateQ3_시네마틱연출05 : TriggerState {
            internal StateQ3_시네마틱연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "27", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "27")) {
                    return new StateQ3_미카퇴장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카퇴장01 : TriggerState {
            internal StateQ3_미카퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 2);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_6013");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new StateQ3_미카퇴장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카퇴장02 : TriggerState {
            internal StateQ3_미카퇴장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT03__2$", arg4: 3);
                context.SetSkip(arg1: "Q3_미카퇴장03");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new StateQ3_미카퇴장03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_미카퇴장03 : TriggerState {
            internal StateQ3_미카퇴장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_6014");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8010, arg2: new[] {601})) {
                    return new StateQ3_미카퇴장04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_미카퇴장04 : TriggerState {
            internal StateQ3_미카퇴장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601});
                context.SetTimer(arg1: "40", arg2: 1);
                context.CameraSelect(arg1: 4001, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "40")) {
                    return new StateQ3_Achievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_Achievement : TriggerState {
            internal StateQ3_Achievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "Intothememory");
                context.DestroyMonster(arg1: new[] {501});
                context.CreateMonster(arg1: new[] {502}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002823}, arg3: new byte[] {2})) {
                    return new StateQ3_유저퇴장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ3_유저퇴장01 : TriggerState {
            internal StateQ3_유저퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "41", arg2: 2);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "41")) {
                    return new StateQ3_유저퇴장02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_유저퇴장02 : TriggerState {
            internal StateQ3_유저퇴장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "42", arg2: 4);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001316, arg3: "$52010005_QD__ACT03__3$", arg4: 4);
                context.SetSkip(arg1: "Q3_유저퇴장03");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "42")) {
                    return new StateQ3_유저퇴장03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ3_유저퇴장03 : TriggerState {
            internal StateQ3_유저퇴장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveUser(arg1: 02010026, arg2: 3, arg3: 9000);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
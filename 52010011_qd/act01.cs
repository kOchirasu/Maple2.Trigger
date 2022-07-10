using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010011_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetEffect(triggerIds: new []{5000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateQuest시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest시작 : TriggerState {
            internal StateQuest시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002811}, questStates: new byte[]{2})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행 : TriggerState {
            internal State진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010011, portalId: 2, boxId: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScript_01_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_01_테모로 : TriggerState {
            internal StateScript_01_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__0$", arg4: 5);
                context.SetSkip(state: new StateScript_01_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_01_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_01_테모로skip : TriggerState {
            internal StateScript_01_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_02_테모로(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_02_테모로 : TriggerState {
            internal StateScript_02_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__1$", arg4: 5);
                context.SetSkip(state: new StateScript_02_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_02_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_02_테모로skip : TriggerState {
            internal StateScript_02_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_03_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_03_PC : TriggerState {
            internal StateScript_03_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScript_04_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_04_테모로 : TriggerState {
            internal StateScript_04_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__3$", arg4: 5);
                context.SetSkip(state: new StateScript_04_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_04_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_04_테모로skip : TriggerState {
            internal StateScript_04_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_05_테모로(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_05_테모로 : TriggerState {
            internal StateScript_05_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__4$", arg4: 5);
                context.SetSkip(state: new StateScript_05_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_05_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_05_테모로skip : TriggerState {
            internal StateScript_05_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_06_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_06_PC : TriggerState {
            internal StateScript_06_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__5$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScript_07_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_07_테모로 : TriggerState {
            internal StateScript_07_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__6$", arg4: 5);
                context.SetSkip(state: new StateScript_07_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_07_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_07_테모로skip : TriggerState {
            internal StateScript_07_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_08_테모로(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_08_테모로 : TriggerState {
            internal StateScript_08_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__7$", arg4: 5);
                context.SetSkip(state: new StateScript_08_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_08_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_08_테모로skip : TriggerState {
            internal StateScript_08_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_09_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_09_PC : TriggerState {
            internal StateScript_09_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__8$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScript_10_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_10_테모로 : TriggerState {
            internal StateScript_10_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__9$", arg4: 5);
                context.SetSkip(state: new StateScript_10_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_10_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_10_테모로skip : TriggerState {
            internal StateScript_10_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_11_테모로(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_11_테모로 : TriggerState {
            internal StateScript_11_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__10$", arg4: 5);
                context.SetSkip(state: new StateScript_11_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_11_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_11_테모로skip : TriggerState {
            internal StateScript_11_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_12_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_12_PC : TriggerState {
            internal StateScript_12_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__11$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_13_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_13_테모로 : TriggerState {
            internal StateScript_13_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__12$", arg4: 5);
                context.SetSkip(state: new StateScript_13_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_13_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_13_테모로skip : TriggerState {
            internal StateScript_13_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State영상Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State영상Prepare : TriggerState {
            internal State영상Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "21", seconds: 2);
                context.CameraSelectPath(pathIds: new []{601, 602}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: @"common\KarKarIntro.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateScript_14_PC(context);
                }

                if (context.WaitTick(waitTick: 18000)) {
                    return new StateScript_14_PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_14_PC : TriggerState {
            internal StateScript_14_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__13$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScript_15_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_15_테모로 : TriggerState {
            internal StateScript_15_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__14$", arg4: 5);
                context.SetSkip(state: new StateScript_15_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_15_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_15_테모로skip : TriggerState {
            internal StateScript_15_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_16_테모로(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_16_테모로 : TriggerState {
            internal StateScript_16_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001314, script: "$52010011_QD__ACT01__15$", arg4: 5);
                context.SetSkip(state: new StateScript_16_테모로skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_16_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_16_테모로skip : TriggerState {
            internal StateScript_16_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CreateMonster(spawnIds: new []{1001}, arg2: true);
                context.SetSkip(state: new StateScript_17_덴덴(context));
            }

            public override TriggerState? Execute() {
                return new StateScript_17_덴덴(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_17_덴덴 : TriggerState {
            internal StateScript_17_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_2001");
                context.SetConversation(type: 2, spawnId: 11001313, script: "$52010011_QD__ACT01__16$", arg4: 5);
                context.SetSkip(state: new StateScript_17_덴덴skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScript_17_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_17_덴덴skip : TriggerState {
            internal StateScript_17_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_18_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_18_PC : TriggerState {
            internal StateScript_18_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__17$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScript_19_덴덴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_19_덴덴 : TriggerState {
            internal StateScript_19_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001313, script: "$52010011_QD__ACT01__18$", arg4: 4);
                context.SetSkip(state: new StateScript_19_덴덴skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScript_19_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_19_덴덴skip : TriggerState {
            internal StateScript_19_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateScript_20_PC(context);
            }

            public override void OnExit() { }
        }

        private class StateScript_20_PC : TriggerState {
            internal StateScript_20_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52010011_QD__ACT01__19$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScript_21_덴덴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_21_덴덴 : TriggerState {
            internal StateScript_21_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001313, script: "$52010011_QD__ACT01__20$", arg4: 3);
                context.SetSkip(state: new StateScript_21_덴덴skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScript_21_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript_21_덴덴skip : TriggerState {
            internal StateScript_21_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

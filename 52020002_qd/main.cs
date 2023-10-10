namespace Maple2.Trigger._52020002_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: true);
                context.DestroyMonster(spawnIds: new []{120, 121});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001779}, questStates: new byte[]{3})) {
                    return new State진행이후_기본(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001775, 50001776, 50001777, 50001778, 50001779}, questStates: new byte[]{1, 2})) {
                    return new State제이든보고Cinematic_완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001774}, questStates: new byte[]{3})) {
                    return new State제이든보고Cinematic_완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001774}, questStates: new byte[]{2})) {
                    return new State제이든보고Cinematic_완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001774}, questStates: new byte[]{1})) {
                    return new State제이든보고Cinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{3})) {
                    return new StateDefault(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefault : TriggerState {
            internal StateDefault(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행이후_기본 : TriggerState {
            internal State진행이후_기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
                context.DestroyMonster(spawnIds: new []{120, 121});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든보고Cinematic_Wait : TriggerState {
            internal State제이든보고Cinematic_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{120}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020002, portalId: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetSceneSkip(state: new State제이든보고_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제이든Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든Spawn : TriggerState {
            internal State제이든Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003540, illustId: "Jaiden_normal", script: @"안녕하세요? 제가 나타났습니다.\n연출은 제작 중이니 기다려 주세요.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 120, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이든보고_스킵완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01_skip : TriggerState {
            internal State01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State제이든보고_스킵완료(context);
            }

            public override void OnExit() { }
        }

        private class State제이든보고_스킵완료 : TriggerState {
            internal State제이든보고_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{120});
                context.CreateMonster(spawnIds: new []{121}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "JaidenReportstoRadin");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든보고Cinematic_완료 : TriggerState {
            internal State제이든보고Cinematic_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{120});
                context.CreateMonster(spawnIds: new []{121}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

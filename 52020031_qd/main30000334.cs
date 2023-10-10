namespace Maple2.Trigger._52020031_qd {
    public static class _main30000334 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{30000334}, questStates: new byte[]{1})) {
                    return new State세번째전투끝나고(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고 : TriggerState {
            internal State세번째전투끝나고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째전투끝나고1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고1 : TriggerState {
            internal State세번째전투끝나고1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State세번째전투끝나고2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고2 : TriggerState {
            internal State세번째전투끝나고2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020031, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State세번째전투끝나고2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고2_2 : TriggerState {
            internal State세번째전투끝나고2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.FaceEmotion(spawnId: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 0, script: @"역시 너희 흑성회는 믿을 만한 사람들이 아니었군.\n천공의 심장은 내가 가져가겠어.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State세번째전투끝나고3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고3 : TriggerState {
            internal State세번째전투끝나고3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.AddCinematicTalk(npcId: 11003756, script: "크윽...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세번째전투끝나고3_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고3_01 : TriggerState {
            internal State세번째전투끝나고3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State세번째전투끝나고4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투끝나고4 : TriggerState {
            internal State세번째전투끝나고4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "오늘 있었던 일은, 라딘에게도 전하겠어.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "흑성회와의 동맹은 여기까지야.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State천공의탑으로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State천공의탑으로이동 : TriggerState {
            internal State천공의탑으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52020030, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

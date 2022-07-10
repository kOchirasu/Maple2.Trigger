using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000124_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100105, 60100106, 60100107, 60100108, 60100109, 60100110}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100110}, questStates: new byte[]{3})) {
                    return new StateDelnpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera : TriggerState {
            internal StateCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4001, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003195, script: "$52000124_QD__MAIN__0$", duration: 2000, align: Align.Right);
                context.SetSceneSkip(state: new StateScene_07(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003195, script: "$52000124_QD__MAIN__1$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11000069, script: "$52000124_QD__MAIN__2$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003195, script: "$52000124_QD__MAIN__3$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Sit_down_A", duration: 999999999999f);
                context.AddCinematicTalk(npcId: 11000069, script: "$52000124_QD__MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003195, script: "$52000124_QD__MAIN__5$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.DestroyMonster(spawnIds: new []{202});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100110}, questStates: new byte[]{2})) {
                    return new StateWarptalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarptalk : TriggerState {
            internal StateWarptalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 201, msg: "$52000124_QD__MAIN__6$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000073, portalId: 4);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelnpc : TriggerState {
            internal StateDelnpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 202});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

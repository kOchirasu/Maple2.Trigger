using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {60100245}, arg3: new byte[] {2})) {
                    return new StateReady(context);
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
                context.SetSceneSkip(state: new StateEnd(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePcmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePcmove : TriggerState {
            internal StatePcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateErebTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_01 : TriggerState {
            internal StateErebTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {700}, arg2: false);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", script: "$52000033_QD__AUDIENCEWITHEREB_03__0$", duration: 3000, delayTick: 0, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateErebTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_02 : TriggerState {
            internal StateErebTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {901}, arg2: false);
                context.AddCinematicTalk(npcId: 11001663, script: "$52000033_QD__AUDIENCEWITHEREB_03__1$", duration: 3000, delayTick: 0, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_03 : TriggerState {
            internal StateErebTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStory_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStory_01 : TriggerState {
            internal StateStory_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000033_QD__AUDIENCEWITHEREB_03__2$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStory_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStory_02 : TriggerState {
            internal StateStory_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000033_QD__AUDIENCEWITHEREB_03__3$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStory_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStory_03 : TriggerState {
            internal StateStory_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000033_QD__AUDIENCEWITHEREB_03__4$", arg3: false);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_1005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateErebTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_04 : TriggerState {
            internal StateErebTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_surprise", script: "$52000033_QD__AUDIENCEWITHEREB_03__5$", duration: 3000, delayTick: 0, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateErebTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_05 : TriggerState {
            internal StateErebTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_closeEye", script: "$52000033_QD__AUDIENCEWITHEREB_03__6$", duration: 3000, delayTick: 0, align: Align.Left);
                context.AddBalloonTalk(spawnPointId: 401, msg: "$52000033_QD__AUDIENCEWITHEREB_03__7$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebTalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_06 : TriggerState {
            internal StateErebTalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_serious", script: "$52000033_QD__AUDIENCEWITHEREB_03__8$", duration: 3000, delayTick: 0, align: Align.Left);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_1006");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateErebTalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_07 : TriggerState {
            internal StateErebTalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_closeEye", script: "$52000033_QD__AUDIENCEWITHEREB_03__9$", duration: 3000, delayTick: 0, align: Align.Left);
                context.DestroyMonster(arg1: new[] {601});
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {601});
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
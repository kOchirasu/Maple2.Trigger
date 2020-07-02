namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {60100010}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 52000033, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePcmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePcmove : TriggerState {
            internal StatePcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateErebTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_01 : TriggerState {
            internal StateErebTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {700}, arg2: false);
                context.AddCinematicTalk(npcId: 11001663, msg: "$52000033_QD__AUDIENCEWITHEREB_02__0$", duration: 5000);
                context.SetSceneSkip(arg1: "end", arg2: "nextState");
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
                context.CameraSelectPath(arg1: new[] {901}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001663, msg: "$52000033_QD__AUDIENCEWITHEREB_02__1$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebintroduce(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebintroduce : TriggerState {
            internal StateErebintroduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", scale: 2.3f, title: "$52000033_QD__AUDIENCEWITHEREB_02__18$", desc: "$52000033_QD__AUDIENCEWITHEREB_02__19$", align: "centerLeft", offsetRateX: -0.15f, duration: 3000);
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
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001663, msg: "$52000033_QD__AUDIENCEWITHEREB_02__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001663, msg: "$52000033_QD__AUDIENCEWITHEREB_02__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKaltalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltalk_01 : TriggerState {
            internal StateKaltalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001665, msg: "$52000033_QD__AUDIENCEWITHEREB_02__4$", duration: 3000, illustId: "Karl_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKaltalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltalk_02 : TriggerState {
            internal StateKaltalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {902}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001665, msg: "$52000033_QD__AUDIENCEWITHEREB_02__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001665, msg: "$52000033_QD__AUDIENCEWITHEREB_02__6$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKaltroduce(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltroduce : TriggerState {
            internal StateKaltroduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", scale: 2.3f, title: "$52000033_QD__AUDIENCEWITHEREB_02__20$", desc: "$52000033_QD__AUDIENCEWITHEREB_02__21$", align: "centerLeft", offsetRateX: -0.15f, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {601}, arg2: false);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__7$", duration: 1000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__8$", duration: 3000, delayTick: 0, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_serious", msg: "$52000033_QD__AUDIENCEWITHEREB_02__9$", duration: 3000, delayTick: 3, align: "center");
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_closeEye", msg: "$52000033_QD__AUDIENCEWITHEREB_02__10$", duration: 1000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__11$", duration: 1000, delayTick: 0, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6649)) {
                    return new StateTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_03 : TriggerState {
            internal StateTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__12$", duration: 3000, align: "Right");
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__13$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_04 : TriggerState {
            internal StateTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__14$", duration: 3000, align: "Right");
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__15$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_05 : TriggerState {
            internal StateTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__16$", duration: 3000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__17$", duration: 3000, delayTick: 3, align: "right");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "AudienceWithEreb");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {60100010}, arg3: new byte[] {1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
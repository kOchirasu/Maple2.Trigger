namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {60100010}, arg3: new byte[] {1})) {
                    return new Stateready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000033, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statepcmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepcmove : TriggerState {
            internal Statepcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                context.ShowCaption(scale: 2.3f, type: "NameCaption", title: "$52000033_QD__AUDIENCEWITHEREB_02__18$", desc: "$52000033_QD__AUDIENCEWITHEREB_02__19$", align: "centerLeft", offsetRateX: -0.15f, duration: 3000);
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
                    return new Statekaltroduce(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statekaltroduce : TriggerState {
            internal Statekaltroduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(scale: 2.3f, type: "NameCaption", title: "$52000033_QD__AUDIENCEWITHEREB_02__20$", desc: "$52000033_QD__AUDIENCEWITHEREB_02__21$", align: "centerLeft", offsetRateX: -0.15f, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_01 : TriggerState {
            internal Statetalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {601}, arg2: false);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__7$", duration: 1000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__8$", duration: 3000, delayTick: 0, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_02 : TriggerState {
            internal Statetalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_serious", msg: "$52000033_QD__AUDIENCEWITHEREB_02__9$", duration: 3000, delayTick: 3, align: "center");
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_closeEye", msg: "$52000033_QD__AUDIENCEWITHEREB_02__10$", duration: 1000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__11$", duration: 1000, delayTick: 0, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6649)) {
                    return new Statetalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_03 : TriggerState {
            internal Statetalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__12$", duration: 3000, align: "Right");
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__13$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statetalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_04 : TriggerState {
            internal Statetalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__14$", duration: 3000, align: "Right");
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__15$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new Statetalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_05 : TriggerState {
            internal Statetalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__16$", duration: 3000, delayTick: 0, align: "left");
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", msg: "$52000033_QD__AUDIENCEWITHEREB_02__17$", duration: 3000, delayTick: 3, align: "right");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "AudienceWithEreb");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {60100010}, arg3: new byte[] {1})) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
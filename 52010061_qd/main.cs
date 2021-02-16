using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010061_qd {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {6001}, arg2: new[] {91000076}, arg3: new byte[] {3})) {
                    return new State칼리브해안전경(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {6001}, arg2: new[] {91000076}, arg3: new byte[] {3})) {
                    return new State맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경 : TriggerState {
            internal State칼리브해안전경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(isVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State칼리브해안전경_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경_02 : TriggerState {
            internal State칼리브해안전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateEnd_02(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {4001, 4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State칼리브해안전경_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경_03 : TriggerState {
            internal State칼리브해안전경_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010061_QD__main__0$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 2800, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new State교역선비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교역선비추기 : TriggerState {
            internal State교역선비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State스폰조절(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰조절 : TriggerState {
            internal State스폰조절(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {102}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {103}, arg2: false, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State교역선비추기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교역선비추기_02 : TriggerState {
            internal State교역선비추기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {4003, 4005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State레잔Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레잔Script_01 : TriggerState {
            internal State레잔Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11003846, script: "$52010061_QD__main__1$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레잔Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레잔Script_02 : TriggerState {
            internal State레잔Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003846, script: "$52010061_QD__main__2$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State유페리아Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script_01 : TriggerState {
            internal State유페리아Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 6000f);
                context.AddCinematicTalk(npcId: 11003844, illustId: "Yuperia_normal", script: "$52010061_QD__main__3$", duration: 4800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State랜듀비앙Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙Script_01 : TriggerState {
            internal State랜듀비앙Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11001567, illustId: "Renduebian_normal", script: "$52010061_QD__main__4$", duration: 4800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State랜듀비앙Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙Script_02 : TriggerState {
            internal State랜듀비앙Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11001567, illustId: "Renduebian_normal", script: "$52010061_QD__main__5$", duration: 3800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State유페리아Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script_02 : TriggerState {
            internal State유페리아Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11003844, illustId: "Yuperia_normal", script: "$52010061_QD__main__6$", duration: 3800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State랜듀비앙Script_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙Script_03 : TriggerState {
            internal State랜듀비앙Script_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.CameraSelectPath(pathIds: new[] {4010}, arg2: false);
                context.AddCinematicTalk(npcId: 11001567, illustId: "Renduebian_normal", script: "$52010061_QD__main__7$", duration: 3800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateIshuraSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraSpawn : TriggerState {
            internal StateIshuraSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateIshuraSpawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraSpawn_02 : TriggerState {
            internal StateIshuraSpawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001975, script: "$52010061_QD__main__8$", duration: 4000);
                context.CreateMonster(arg1: new[] {104}, arg2: false, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateIshuraSpawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraSpawn_03 : TriggerState {
            internal StateIshuraSpawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4006, 4007}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIshura대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대사 : TriggerState {
            internal StateIshura대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11003845, illustId: "Ishura_normal", script: "$52010061_QD__main__9$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateIshura모션(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura모션 : TriggerState {
            internal StateIshura모션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "RuneBlader_Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 300, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateUIReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUIReset : TriggerState {
            internal StateUIReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104});
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
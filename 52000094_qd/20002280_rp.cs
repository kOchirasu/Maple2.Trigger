namespace Maple2.Trigger._52000094_qd {
    public static class _20002280_rp {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {50100550}, arg3: new byte[] {3})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {20002280}, arg3: new byte[] {3})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003, 3004}, arg2: false);
                context.SetLocalCamera(cameraId: 302, enable: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107}, isAutoTargeting: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State타이틀(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이틀 : TriggerState {
            internal State타이틀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000094, arg2: 99);
                context.AddBuff(arg1: new[] {9100}, arg2: 99910170, arg3: 1, arg4: false, arg5: false);
                context.SetCinematicUI(type: 9, script: "$52000094_QD__20002280_RP__0$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State블랙아이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙아이Script01 : TriggerState {
            internal State블랙아이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003, 3004}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$52000094_QD__20002280_RP__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRP시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRP시작 : TriggerState {
            internal StateRP시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 300, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200941, textId: 25200941, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107})) {
                    return new State데블린소환(context);
                }

                if (context.WaitTick(waitTick: 40000)) {
                    return new State데블린소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데블린소환 : TriggerState {
            internal State데블린소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {2199}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State데블린DeadWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데블린DeadWait : TriggerState {
            internal State데블린DeadWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200942, textId: 25200942, duration: 4000);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 300, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2199})) {
                    return new State미션완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료 : TriggerState {
            internal State미션완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107});
                context.SetEventUI(arg1: 7, script: "$52000094_QD__20002280_RP__2$", arg3: 3000, arg4: "0");
                context.SetLocalCamera(cameraId: 302, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetLocalCamera(cameraId: 302, enable: false);
                    return new State미션완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료02 : TriggerState {
            internal State미션완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {2200, 2201}, arg2: true);
                context.RemoveBuff(arg1: 9100, arg2: 99910170);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAchievement(arg1: 9100, arg2: "trigger", arg3: "BlackEyeRpClear");
                context.MoveUser(arg1: 52000094, arg2: 99);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
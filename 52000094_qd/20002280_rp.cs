namespace Maple2.Trigger._52000094_qd {
    public static class _20002280_rp {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{50100550}, questStates: new byte[]{3})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{20002280}, questStates: new byte[]{3})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3003, 3004}, visible: false);
                context.SetLocalCamera(cameraId: 302, enable: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 300, enable: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SpawnNpcRange(rangeId: new []{1001, 1002, 1003, 1004, 1005}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000094, portalId: 99);
                context.AddBuff(boxIds: new []{9100}, skillId: 99910170, level: 1, arg4: false, arg5: false);
                context.SetCinematicUI(type: 9, script: "$52000094_QD__20002280_RP__0$");
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{3003, 3004}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(type: 2, spawnId: 11000006, script: "$52000094_QD__20002280_RP__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 300, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200941, textId: 25200941, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107})) {
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
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{2199}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200942, textId: 25200942, duration: 4000);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 300, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2199})) {
                    return new State미션완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료 : TriggerState {
            internal State미션완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107});
                context.SetEventUI(arg1: 7, script: "$52000094_QD__20002280_RP__2$", duration: 3000, boxId: 0);
                context.SetLocalCamera(cameraId: 302, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{2200, 2201}, arg2: true);
                context.RemoveBuff(boxId: 9100, skillId: 99910170);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAchievement(triggerId: 9100, type: "trigger", code: "BlackEyeRpClear");
                context.MoveUser(mapId: 52000094, portalId: 99);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

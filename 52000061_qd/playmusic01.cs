namespace Maple2.Trigger._52000061_qd {
    public static class _playmusic01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5100, 5200}, visible: false);
                context.SetSound(triggerId: 10000, enabled: false);
                context.CreateMonster(spawnIds: new []{101, 201, 202, 203, 204}, arg2: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000550}, questStates: new byte[]{1})) {
                    return new StateLodingDelay01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000550}, questStates: new byte[]{2})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCWalkInStage01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage01 : TriggerState {
            internal StatePCWalkInStage01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000061, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCWalkInStage02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage02 : TriggerState {
            internal StatePCWalkInStage02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCWalkInStage03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage03 : TriggerState {
            internal StatePCWalkInStage03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{601, 602}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StatePCWalkInStage04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWalkInStage04 : TriggerState {
            internal StatePCWalkInStage04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 603, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCBow01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBow01 : TriggerState {
            internal StatePCBow01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Chin_Chin_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StatePCBow02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBow02 : TriggerState {
            internal StatePCBow02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCBow03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBow03 : TriggerState {
            internal StatePCBow03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.CameraSelect(triggerId: 610, enabled: true);
                context.MoveUser(mapId: 52000061, portalId: 20);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCReadyToPlayThePiano01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCReadyToPlayThePiano01 : TriggerState {
            internal StatePCReadyToPlayThePiano01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Music_Piano_Idle_A", duration: 31500f);
                context.SetEffect(triggerIds: new []{5100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCPlayMusic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic01 : TriggerState {
            internal StatePCPlayMusic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(triggerId: 10000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCPlayMusic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic02 : TriggerState {
            internal StatePCPlayMusic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Play_A", duration: 30500f);
                context.SetNpcEmotionLoop(spawnId: 204, sequenceName: "Play_A", duration: 30500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30500)) {
                    return new StatePCPlayMusic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayMusic03 : TriggerState {
            internal StatePCPlayMusic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, enabled: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004}, visible: false);
                context.SetEffect(triggerIds: new []{5200}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCPlayQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit01 : TriggerState {
            internal StatePCPlayQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5100}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePCPlayQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit02 : TriggerState {
            internal StatePCPlayQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000061, portalId: 30);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCPlayQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPlayQuit03 : TriggerState {
            internal StatePCPlayQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "PerformanceWithNPC");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000550}, questStates: new byte[]{3})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

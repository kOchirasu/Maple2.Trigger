namespace Maple2.Trigger._52000075_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002668}, questStates: new byte[]{3})) {
                    return new StateRemoveNpc01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002668}, questStates: new byte[]{2})) {
                    return new StateGuardDown01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002668}, questStates: new byte[]{1})) {
                    return new StateGuardDown01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{3})) {
                    return new StateGuardDown01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{2})) {
                    return new StateGuardDown01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveNpc01 : TriggerState {
            internal StateRemoveNpc01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, visible: true);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{202, 900, 901, 902}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900, 901, 902})) {
                    return new StateMobChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobChange01 : TriggerState {
            internal StateMobChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobChange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobChange02 : TriggerState {
            internal StateMobChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000075, portalId: 10);
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobChange03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobChange03 : TriggerState {
            internal StateMobChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobChange04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobChange04 : TriggerState {
            internal StateMobChange04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTalk01 : TriggerState {
            internal StateMobTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001960, script: "$52000075_QD__QUESTNPCSPAWN01__0$", arg4: 4);
                context.SetSkip(state: new StateMobTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMobTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTalk02 : TriggerState {
            internal StateMobTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTalk03 : TriggerState {
            internal StateMobTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enabled: false);
                context.DestroyMonster(spawnIds: new []{301});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestComplete01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "abductedRamon");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuardDown01 : TriggerState {
            internal StateGuardDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._52000072_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002684}, questStates: new byte[]{2})) {
                    // return new StateNpcRemove01(context);
                    return null;
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002684}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002683}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002683}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002683}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002682}, questStates: new byte[]{3})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002682}, questStates: new byte[]{2})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002682}, questStates: new byte[]{1})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002681}, questStates: new byte[]{3})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002681}, questStates: new byte[]{2})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002681}, questStates: new byte[]{1})) {
                    return new StateSetCamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange02 : TriggerState {
            internal StateNpcChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetCamera01 : TriggerState {
            internal StateSetCamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateActEnd01(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetCamera02 : TriggerState {
            internal StateSetCamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enabled: true);
                context.CreateMonster(spawnIds: new []{102, 301, 401}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateActStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart01 : TriggerState {
            internal StateActStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_401");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateActStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart02 : TriggerState {
            internal StateActStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateActStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart03 : TriggerState {
            internal StateActStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateActEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd01 : TriggerState {
            internal StateActEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{301, 401});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateActEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd02 : TriggerState {
            internal StateActEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateActEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd03 : TriggerState {
            internal StateActEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete : TriggerState {
            internal StateQuestComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "triangularRelation");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

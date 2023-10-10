using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._52100051_qd {
    public static class _01_enter {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3006, 3007, 3008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3005, 3008, 3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{102, 202, 300, 301, 900, 901, 910, 911, 912, 913, 920, 921, 922});
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: false);
                context.SetMesh(triggerIds: new []{3202, 3203}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: false);
                context.SetInteractObject(interactIds: new []{10002078}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{300, 301}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001592, script: "$52100051_QD__01_ENTER__0$", arg4: 4);
                context.SetSkip(state: new StateNpcTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNpcTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01Skip : TriggerState {
            internal StateNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateNpcTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02 : TriggerState {
            internal StateNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001597, script: "$52100051_QD__01_ENTER__1$", arg4: 5);
                context.SetSkip(state: new StateNpcTalk02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNpcTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02Skip : TriggerState {
            internal StateNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateNpcMonologue01(context);
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52100051_QD__01_ENTER__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 201, script: "$52100051_QD__01_ENTER__3$", arg4: 2, arg5: 0);
                context.SetUserValue(triggerId: 2, key: "MobSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 101);
                context.RemoveBalloonTalk(spawnId: 201);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNpcMonologue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52100051_QD__01_ENTER__4$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 202, script: "$52100051_QD__01_ENTER__5$", arg4: 2, arg5: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039501, textId: 20039501, duration: 4000);
                context.SetInteractObject(interactIds: new []{10002078}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002078}, arg2: 0)) {
                    return new StateGratingOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen01 : TriggerState {
            internal StateGratingOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039502, textId: 20039502, duration: 4000);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGratingOpen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen02 : TriggerState {
            internal StateGratingOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{910}, arg2: false);
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGratingOpen03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen03 : TriggerState {
            internal StateGratingOpen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: false);
                context.CreateMonster(spawnIds: new []{911, 912, 913}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateMobSpawn_Hallway01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_Hallway01 : TriggerState {
            internal StateMobSpawn_Hallway01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039503, textId: 20039503, duration: 4000);
                context.CreateMonster(spawnIds: new []{920}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateMobSpawn_Hallway02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_Hallway02 : TriggerState {
            internal StateMobSpawn_Hallway02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{921, 922}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039504, textId: 20039504, duration: 4000);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

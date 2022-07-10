namespace Maple2.Trigger._52010038_qd {
    public static class _event {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013}, visible: true);
                context.SetSkill(triggerIds: new []{710, 711}, arg2: false);
                context.SetEffect(triggerIds: new []{6110, 6111, 6298}, visible: false);
                context.SetActor(triggerId: 220, visible: false);
                context.SetActor(triggerId: 221, visible: false);
                context.SetActor(triggerId: 222, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EventStart") == 1) {
                    return new State이벤트조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트조건 : TriggerState {
            internal State이벤트조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6298}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State이벤트시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트시작 : TriggerState {
            internal State이벤트시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1200}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1201});
                context.SetConversation(type: 1, spawnId: 1200, script: "$52010038_QD__EVENT__0$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 1200, patrolName: "MS2PatrolData_1200");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 104, spawnIds: new []{1200})) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{710}, arg2: true);
                context.SetEffect(triggerIds: new []{6110}, visible: true);
                context.CreateMonster(spawnIds: new []{2012, 2013, 2014, 2015}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State감지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지Wait : TriggerState {
            internal State감지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013}, visible: false);
                context.SetConversation(type: 1, spawnId: 1200, script: "$52010038_QD__EVENT__2$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State폭발시퀀스시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발시퀀스시작 : TriggerState {
            internal State폭발시퀀스시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 220, visible: true, initialSequence: "Regen_A");
                context.SetActor(triggerId: 221, visible: true, initialSequence: "Regen_A");
                context.SetActor(triggerId: 222, visible: true, initialSequence: "Regen_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State폭발Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발Delay : TriggerState {
            internal State폭발Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 220, visible: true, initialSequence: "Attack_01_A");
                context.SetActor(triggerId: 221, visible: true, initialSequence: "Attack_01_A");
                context.SetActor(triggerId: 222, visible: true, initialSequence: "Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State폭발(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발 : TriggerState {
            internal State폭발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 220, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 221, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 222, visible: true, initialSequence: "Attack_02_A");
                context.SetSkill(triggerIds: new []{711}, arg2: true);
                context.SetEffect(triggerIds: new []{6298}, visible: false);
                context.SetEffect(triggerIds: new []{6111}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State폭탄숨김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭탄숨김 : TriggerState {
            internal State폭탄숨김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 220, visible: false);
                context.SetActor(triggerId: 221, visible: false);
                context.SetActor(triggerId: 222, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    return new State점수(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State점수 : TriggerState {
            internal State점수(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4010, 4030}, arg2: false);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$52010038_QD__event__4$", voice: @"ko/Npc/00002105");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_09 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 9001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9003, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000353}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000353}, arg2: 0)) {
                    return new State깨어남1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남1 : TriggerState {
            internal State깨어남1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 8);
                context.SetActor(triggerId: 9001, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 9004, visible: false, initialSequence: "Bore_A");
                context.SetActor(triggerId: 9005, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9006, visible: false, initialSequence: "Stun_A");
                context.CreateMonster(spawnIds: new []{90004}, arg2: true);
                context.SetConversation(type: 1, spawnId: 90004, script: "$02000320_BF__WAKEUP_09__0$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{90005}, arg2: true);
                context.SetConversation(type: 1, spawnId: 90005, script: "$02000320_BF__WAKEUP_09__1$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{90006}, arg2: true);
                context.SetConversation(type: 1, spawnId: 90006, script: "$02000320_BF__WAKEUP_09__2$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{90001});
                context.CreateMonster(spawnIds: new []{90002});
                context.CreateMonster(spawnIds: new []{90003});
                context.SetConversation(type: 1, spawnId: 90003, script: "$02000320_BF__WAKEUP_09__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 90001, script: "$02000320_BF__WAKEUP_09__4$", arg4: 2, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State깨어남2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남2 : TriggerState {
            internal State깨어남2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 4);
                context.SetConversation(type: 1, spawnId: 90002, script: "$02000320_BF__WAKEUP_09__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 90001, script: "$02000320_BF__WAKEUP_09__6$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 90003, script: "$02000320_BF__WAKEUP_09__7$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State깨어남3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남3 : TriggerState {
            internal State깨어남3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 1);
                context.SetActor(triggerId: 9001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State깨어남4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남4 : TriggerState {
            internal State깨어남4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{90004, 90005, 90006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{90004, 90005, 90006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 90004);
                context.RemoveBalloonTalk(spawnId: 90005);
                context.RemoveBalloonTalk(spawnId: 90006);
                context.RemoveBalloonTalk(spawnId: 90001);
                context.RemoveBalloonTalk(spawnId: 90002);
                context.RemoveBalloonTalk(spawnId: 90003);
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 90004, script: "$02000320_BF__WAKEUP_09__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 90005, script: "$02000320_BF__WAKEUP_09__9$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 90006, script: "$02000320_BF__WAKEUP_09__10$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State다시잠듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시잠듬 : TriggerState {
            internal State다시잠듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{90001, 90002, 90003, 90004, 90005, 90006});
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetActor(triggerId: 9004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 9006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State도둑듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

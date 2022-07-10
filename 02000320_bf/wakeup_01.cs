namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_01 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1002, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1003, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000281}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000281}, arg2: 0)) {
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
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 1002, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 1004, visible: false, initialSequence: "Bore_A");
                context.SetActor(triggerId: 1005, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1006, visible: false, initialSequence: "Stun_A");
                context.CreateMonster(spawnIds: new []{10004}, arg2: true);
                context.SetConversation(type: 1, spawnId: 10004, script: "$02000320_BF__WAKEUP_01__0$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{10005}, arg2: true);
                context.SetConversation(type: 1, spawnId: 10005, script: "$02000320_BF__WAKEUP_01__1$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{10006}, arg2: true);
                context.SetConversation(type: 1, spawnId: 10006, script: "$02000320_BF__WAKEUP_01__2$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{10001});
                context.CreateMonster(spawnIds: new []{10002});
                context.CreateMonster(spawnIds: new []{10003});
                context.SetConversation(type: 1, spawnId: 10003, script: "$02000320_BF__WAKEUP_01__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 10001, script: "$02000320_BF__WAKEUP_01__4$", arg4: 2, arg5: 4);
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
                context.SetConversation(type: 1, spawnId: 10002, script: "$02000320_BF__WAKEUP_01__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 10001, script: "$02000320_BF__WAKEUP_01__6$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 10003, script: "$02000320_BF__WAKEUP_01__7$", arg4: 2, arg5: 2);
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
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1002, visible: true, initialSequence: "Stun_A");
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
                if (context.MonsterDead(spawnIds: new []{10004, 10005, 10006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{10004, 10005, 10006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 10004);
                context.RemoveBalloonTalk(spawnId: 10005);
                context.RemoveBalloonTalk(spawnId: 10006);
                context.RemoveBalloonTalk(spawnId: 10001);
                context.RemoveBalloonTalk(spawnId: 10002);
                context.RemoveBalloonTalk(spawnId: 10003);
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 10004, script: "$02000320_BF__WAKEUP_01__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 10005, script: "$02000320_BF__WAKEUP_01__9$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 10006, script: "$02000320_BF__WAKEUP_01__10$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{10001, 10002, 10003, 10004, 10005, 10006});
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetActor(triggerId: 1004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 1006, visible: true, initialSequence: "Stun_A");
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

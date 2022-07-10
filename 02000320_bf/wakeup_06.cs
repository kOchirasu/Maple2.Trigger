namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_06 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 6001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6002, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6003, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000350}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000350}, arg2: 0)) {
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
                context.SetActor(triggerId: 6001, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 6002, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 6004, visible: false, initialSequence: "Bore_A");
                context.SetActor(triggerId: 6005, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6006, visible: false, initialSequence: "Stun_A");
                context.CreateMonster(spawnIds: new []{60004}, arg2: true);
                context.SetConversation(type: 1, spawnId: 60004, script: "$02000320_BF__WAKEUP_06__0$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{60005}, arg2: true);
                context.SetConversation(type: 1, spawnId: 60005, script: "$02000320_BF__WAKEUP_06__1$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{60006}, arg2: true);
                context.SetConversation(type: 1, spawnId: 60006, script: "$02000320_BF__WAKEUP_06__2$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{60001});
                context.CreateMonster(spawnIds: new []{60002});
                context.CreateMonster(spawnIds: new []{60003});
                context.SetConversation(type: 1, spawnId: 60003, script: "$02000320_BF__WAKEUP_06__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 60001, script: "$02000320_BF__WAKEUP_06__4$", arg4: 2, arg5: 4);
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
                context.SetConversation(type: 1, spawnId: 60002, script: "$02000320_BF__WAKEUP_06__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 60001, script: "$02000320_BF__WAKEUP_06__6$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 60003, script: "$02000320_BF__WAKEUP_06__7$", arg4: 2, arg5: 2);
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
                context.SetActor(triggerId: 6001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6002, visible: true, initialSequence: "Stun_A");
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
                if (context.MonsterDead(spawnIds: new []{60004, 60005, 60006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{60004, 60005, 60006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 60004);
                context.RemoveBalloonTalk(spawnId: 60005);
                context.RemoveBalloonTalk(spawnId: 60006);
                context.RemoveBalloonTalk(spawnId: 60001);
                context.RemoveBalloonTalk(spawnId: 60002);
                context.RemoveBalloonTalk(spawnId: 60003);
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 60004, script: "$02000320_BF__WAKEUP_06__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 60005, script: "$02000320_BF__WAKEUP_06__9$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 60006, script: "$02000320_BF__WAKEUP_06__10$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{60001, 60002, 60003, 60004, 60005, 60006});
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetActor(triggerId: 6004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 6006, visible: true, initialSequence: "Stun_A");
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

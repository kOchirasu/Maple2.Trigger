namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_07 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7002, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7003, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000351}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000351}, arg2: 0)) {
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
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 7002, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 7004, visible: false, initialSequence: "Bore_A");
                context.SetActor(triggerId: 7005, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7006, visible: false, initialSequence: "Stun_A");
                context.CreateMonster(spawnIds: new []{70004}, arg2: true);
                context.SetConversation(type: 1, spawnId: 70004, script: "$02000320_BF__WAKEUP_07__0$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{70005}, arg2: true);
                context.SetConversation(type: 1, spawnId: 70005, script: "$02000320_BF__WAKEUP_07__1$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{70006}, arg2: true);
                context.SetConversation(type: 1, spawnId: 70006, script: "$02000320_BF__WAKEUP_07__2$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{70001});
                context.CreateMonster(spawnIds: new []{70002});
                context.CreateMonster(spawnIds: new []{70003});
                context.SetConversation(type: 1, spawnId: 70003, script: "$02000320_BF__WAKEUP_07__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 70001, script: "$02000320_BF__WAKEUP_07__4$", arg4: 2, arg5: 4);
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
                context.SetConversation(type: 1, spawnId: 70002, script: "$02000320_BF__WAKEUP_07__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 70001, script: "$02000320_BF__WAKEUP_07__6$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 70003, script: "$02000320_BF__WAKEUP_07__7$", arg4: 2, arg5: 2);
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
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7002, visible: true, initialSequence: "Stun_A");
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
                if (context.MonsterDead(spawnIds: new []{70004, 70005, 70006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{70004, 70005, 70006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 70004);
                context.RemoveBalloonTalk(spawnId: 70005);
                context.RemoveBalloonTalk(spawnId: 70006);
                context.RemoveBalloonTalk(spawnId: 70001);
                context.RemoveBalloonTalk(spawnId: 70002);
                context.RemoveBalloonTalk(spawnId: 70003);
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 70004, script: "$02000320_BF__WAKEUP_07__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 70005, script: "$02000320_BF__WAKEUP_07__9$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 70006, script: "$02000320_BF__WAKEUP_07__10$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{70001, 70002, 70003, 70004, 70005, 70006});
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetActor(triggerId: 7004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 7006, visible: true, initialSequence: "Stun_A");
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

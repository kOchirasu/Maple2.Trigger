namespace Maple2.Trigger._02020142_bf {
    public static class _2phasetubeattackcheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "2PhaseTubeStep", value: 0);
                context.SetUserValue(key: "MarbleTurkaSupportMany", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateTrigger작동신호받기대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동신호받기대기중 : TriggerState {
            internal StateTrigger작동신호받기대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhaseTubeStep") >= 1) {
                    return new StateTrigger작동대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동대기중 : TriggerState {
            internal StateTrigger작동대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger작동시작 : TriggerState {
            internal StateTrigger작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhaseTubeStep") == 1) {
                    return new State튜브대미지필드_1단계진행(context);
                }

                if (context.GetUserValue(key: "2PhaseTubeStep") == 2) {
                    return new State튜브대미지필드_2단계전환_우선1단계Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State튜브대미지필드_1단계진행 : TriggerState {
            internal State튜브대미지필드_1단계진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MarbleTurkaSupportMany") >= 1) {
                    return new State1단계_튜브대미지필드_Creation(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State1단계_튜브대미지필드_Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_튜브대미지필드_Creation : TriggerState {
            internal State1단계_튜브대미지필드_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {102}, arg2: 50004566, arg3: 1, arg4: true, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhaseTubeStep") == 2) {
                    return new State튜브대미지필드_2단계전환_우선1단계Remove(context);
                }

                if (context.GetUserValue(key: "MarbleTurkaSupportMany") == 0) {
                    return new State1단계_튜브대미지필드_Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_튜브대미지필드_Remove : TriggerState {
            internal State1단계_튜브대미지필드_Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004566);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhaseTubeStep") == 2) {
                    return new State튜브대미지필드_2단계전환_우선1단계Remove(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State튜브대미지필드_1단계진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State튜브대미지필드_2단계전환_우선1단계Remove : TriggerState {
            internal State튜브대미지필드_2단계전환_우선1단계Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004566);
                context.SetUserValue(key: "TubeLeveStep", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State2단계_튜브대미지필드_처음단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_처음단계 : TriggerState {
            internal State2단계_튜브대미지필드_처음단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MarbleTurkaSupportMany") >= 1) {
                    return new State2단계_튜브대미지필드_1LvCreation(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_1LvCreation : TriggerState {
            internal State2단계_튜브대미지필드_1LvCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {102}, arg2: 50004563, arg3: 1, arg4: true, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_2LvCreation : TriggerState {
            internal State2단계_튜브대미지필드_2LvCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004563);
                context.AddBuff(arg1: new[] {102}, arg2: 50004564, arg3: 1, arg4: true, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_3LvCreation : TriggerState {
            internal State2단계_튜브대미지필드_3LvCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004564);
                context.AddBuff(arg1: new[] {102}, arg2: 50004565, arg3: 1, arg4: true, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_TubeLeveStep_더하기 : TriggerState {
            internal State2단계_튜브대미지필드_TubeLeveStep_더하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddUserValue(key: "TubeLeveStep", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_TubeLeveStep_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_TubeLeveStep_체크 : TriggerState {
            internal State2단계_튜브대미지필드_TubeLeveStep_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TubeLeveStep") == 10) {
                    return new State2단계_튜브대미지필드_2LvCreation(context);
                }

                if (context.GetUserValue(key: "TubeLeveStep") == 20) {
                    return new State2단계_튜브대미지필드_3LvCreation(context);
                }

                if (context.GetUserValue(key: "MarbleTurkaSupportMany") >= 1) {
                    return new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_Remove : TriggerState {
            internal State2단계_튜브대미지필드_Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004563);
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004564);
                context.NpcRemoveAdditionalEffect(spawnPointId: 102, additionalEffectId: 50004565);
                context.SetUserValue(key: "TubeLeveStep", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2단계_튜브대미지필드_처음단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
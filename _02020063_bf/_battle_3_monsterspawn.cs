namespace Maple2.Trigger._02020063_bf {
    public static class _battle_3_monsterspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_3_Clear", value: 0);
                context.StartCombineSpawn(groupId: new[] {500}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {501}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {502}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {503}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {504}, isStart: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.ResetTimer(arg1: "4");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 1) {
                    return new State스폰_1_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_SE : TriggerState {
            internal State스폰_1_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ScoreBoardCreate(maxScore: 900);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1 : TriggerState {
            internal State스폰_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {500}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.TimeExpired(arg1: "1") || context.GetScoreBoardScore() >= 150) {
                    return new State스폰_3_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2_SE : TriggerState {
            internal State스폰_2_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2 : TriggerState {
            internal State스폰_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {501}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2") || context.GetScoreBoardScore() >= 250) {
                    return new State스폰_3_SE(context);
                }

                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3_SE : TriggerState {
            internal State스폰_3_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3 : TriggerState {
            internal State스폰_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 60, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {502}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3") || context.GetScoreBoardScore() >= 500) {
                    return new State스폰_4_SE(context);
                }

                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4_SE : TriggerState {
            internal State스폰_4_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4 : TriggerState {
            internal State스폰_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 60, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {503}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4") || context.GetScoreBoardScore() >= 750) {
                    return new State스폰_5_SE(context);
                }

                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5_SE : TriggerState {
            internal State스폰_5_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5 : TriggerState {
            internal State스폰_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {504}, isStart: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ScoreBoardRemove();
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}